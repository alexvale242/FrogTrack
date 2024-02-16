using Cosmos;
using MediatR;

namespace TestSSRApp.Features.FrogListing;

public class GetFrogs
{
    public class Request : IRequest<Frog[]>
    {
    }

    public record Frog(Guid Id, string Name);

    public class Handler(ILogger<GetFrogs> logger, ICosmosDbContainerFactory cosmosDbContainerFactory) : IRequestHandler<Request, Frog[]>
    {
        public async Task<Frog[]> Handle(Request request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Getting them frogs");

            var container = cosmosDbContainerFactory.GetContainer(ContainerNames.Frogs).Container;

            try
            {
                var query = await container.GetItemLinqQueryable<Cosmos.Models.Frog>().ToFeedResponseAsync(cancellationToken);

                var frogs = query.Select(o => new Frog(o.Id, o.Name)).ToArray();
                return await Task.FromResult(frogs);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}