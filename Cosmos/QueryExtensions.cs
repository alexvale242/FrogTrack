using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;

namespace Cosmos;

public static class QueryExtensions
{
    public static async Task<FeedResponse<TSource>> ToFeedResponseAsync<TSource>(
        this IQueryable<TSource> query,
        CancellationToken cancellationToken)
    {
        var iterator = query.ToFeedIterator();
        return await iterator.ReadNextAsync(cancellationToken);
    }
}
