using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.API.Repository;

internal interface IShortUrlRepository : IBaseRepository
{
    Task<ShortUrl?> GetByShortUrlAsync(string shortUrl);
    Task<bool> CreateAsync(ShortUrl shortUrl);
}
