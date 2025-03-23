using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.API.Repository;

internal interface IShortUrlRepository : IBaseRepository
{
    Task<ShortUrl?> GetByUrlCodeAsync(string urlCode);
    Task<bool> CreateAsync(ShortUrl shortUrl);
}
