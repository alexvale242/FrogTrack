using Microsoft.Azure.Cosmos;

namespace Cosmos;

public interface ICosmosDbContainerFactory
{
    ICosmosDbContainer GetContainer(string containerName);
}

public interface ICosmosDbContainer
{
    Container Container { get; }
}
