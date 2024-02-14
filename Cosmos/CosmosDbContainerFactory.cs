using Microsoft.Azure.Cosmos;

namespace Cosmos;

public class CosmosDbContainerFactory(
    CosmosClient cosmosClient,
    string databaseName) : ICosmosDbContainerFactory
{
    private readonly CosmosClient _cosmosClient = cosmosClient ?? throw new ArgumentNullException(nameof(cosmosClient));
    private readonly string _databaseName = databaseName ?? throw new ArgumentNullException(nameof(databaseName));

    public ICosmosDbContainer GetContainer(string containerName)
        => new CosmosDbContainer(_cosmosClient, _databaseName, containerName);
}