using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.API.Repository;

internal interface IShortUrlRepository : IBaseRepository
{
    Task<ShortUrl?> GetByUrlAsync(string originalUrl);
    Task<bool> CreateAsync(ShortUrl shortUrl);
}
