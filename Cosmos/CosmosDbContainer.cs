using Microsoft.Azure.Cosmos;

namespace Cosmos;

public class CosmosDbContainer : ICosmosDbContainer
{
    public Container Container { get; }

    public CosmosDbContainer(CosmosClient cosmosClient,
        string databaseName,
        string containerName)
    {
        Container = cosmosClient.GetContainer(databaseName, containerName);
    }
}
