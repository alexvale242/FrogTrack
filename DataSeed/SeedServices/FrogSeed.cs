using Cosmos;
using Microsoft.Extensions.Logging;

namespace DataSeed.SeedServices;

public class FrogSeed(ILogger<FrogSeed> logger, ICosmosDbContainerFactory cosmosDbContainerFactory)
{
    public async Task SeedFrogs()
    {
        var container = cosmosDbContainerFactory.GetContainer(ContainerNames.Frogs).Container;

        try
        {
            var query = await container.GetItemLinqQueryable<Cosmos.Models.Frog>().ToFeedResponseAsync(CancellationToken.None);

            var frogs = query.ToArray();

            foreach (var frog in frogs)
            {
                Console.WriteLine(frog.Name);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}