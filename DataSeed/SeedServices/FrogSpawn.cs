using Cosmos;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Logging;

namespace DataSeed.SeedServices;

public class FrogSpawn(ILogger<FrogSpawn> logger, ICosmosDbContainerFactory cosmosDbContainerFactory)
{
    public async Task SeedFrogs()
    {
        var container = cosmosDbContainerFactory.GetContainer(ContainerNames.Frogs).Container;

        try
        {
            logger.LogInformation("Spawning frogs!");
            
            foreach (var frog in Froggies.Frogs)
            {
                await container.UpsertItemAsync(frog, new PartitionKey(frog.Id.ToString()));
            }
            
            logger.LogInformation("Frogs spawned! Listing current frogs:");
            
            var query = await container.GetItemLinqQueryable<Cosmos.Models.Frog>().ToFeedResponseAsync(CancellationToken.None);

            var frogs = query.ToArray();

            foreach (var frog in frogs)
            {
                logger.LogInformation("{frog}", frog.Name);
            }
        }
        catch (Exception e)
        {
            logger.LogError("Unable to access CosmosDB {exception}", e);
        }
    }
}