using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging.Abstractions;

namespace Infrastructure.Test.Caching;

public class LocalCacheService : CacheService<FSH.BackEnd.Infrastructure.Caching.LocalCacheService>
{
    protected override FSH.BackEnd.Infrastructure.Caching.LocalCacheService CreateCacheService() =>
        new(
            new MemoryCache(new MemoryCacheOptions()),
            NullLogger<FSH.BackEnd.Infrastructure.Caching.LocalCacheService>.Instance);
}