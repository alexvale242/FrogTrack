namespace DataSeed.Infrastructure;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Cosmos;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Options;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCosmosDbClient(this IServiceCollection services, IConfiguration config)
    {
        if (config is null)
        {
            throw new ArgumentNullException(nameof(config));
        }

        services.Configure<CosmosDbOptions>(config.GetSection("CosmosDb"));

        // Use a singleton Azure Cosmos DB client for the lifetime of your application
        // https://docs.microsoft.com/en-us/azure/cosmos-db/performance-tips-dotnet-sdk-v3-sql
        services.AddSingleton<ICosmosDbContainerFactory>(provider =>
        {
            var options = provider.GetRequiredService<IOptions<CosmosDbOptions>>().Value;
            var client = GetCosmosClient(options);

            var cosmosDbClientFactory = new CosmosDbContainerFactory(client, options.DatabaseId);
            return cosmosDbClientFactory;
        });

        return services;
    }

    private static CosmosClient GetCosmosClient(CosmosDbOptions options)
    {
        if (options.DisableCertificateValidation)
        {
            var cosmosClientOptions = new CosmosClientOptions()
            {
                ConnectionMode = ConnectionMode.Gateway,
                HttpClientFactory = () =>
                {
                    HttpMessageHandler httpMessageHandler = new HttpClientHandler()
                    {
                        // When running as a local dependency, cosmos DB emulator is running on the host using
                        // a self-signed cert. It's easier to effectively disable certificate validation than
                        // to load the certificate inside docker.
#pragma warning disable SCS0004 // Certificate Validation has been disabled
                        ServerCertificateCustomValidationCallback = (_, _, _, _) => true
#pragma warning restore SCS0004 // Certificate Validation has been disabled
                    };

                    return new HttpClient(httpMessageHandler);
                }
            };

            return new CosmosClient(options.ServiceEndpoint.ToString(), options.AuthKey, cosmosClientOptions);
        }
        else
        {
            return new CosmosClient(options.ServiceEndpoint.ToString(), options.AuthKey);
        }
    }
}