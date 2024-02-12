using TestSSRApp.Features.FrogListing.Models;

namespace TestSSRApp.Features.FrogListing.Queries;

public class GetFrogs(ILogger<GetFrogs> logger)
{
    public async Task<Frog[]> GetFrogsFromMock()
    {
        logger.LogInformation("Getting them frogs");
        
        var frogs = new Frog[]
        {
            new(Guid.NewGuid(), "smol"),
            new(Guid.NewGuid(), "moss"),
            new(Guid.NewGuid(), "rose"),
            new(Guid.NewGuid(), "spots"),
            new(Guid.NewGuid(), "happy"),
            new(Guid.NewGuid(), "angry"),
            new(Guid.NewGuid(), "wholesome"),
            new(Guid.NewGuid(), "plant"),
            new(Guid.NewGuid(), "berry"),
        };
        
        return frogs;
    }
}