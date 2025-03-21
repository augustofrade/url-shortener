using UrlShortener.API.Dto.Shortener;
using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.API.Services;

internal interface IShortUrlService
{
    Task<ShortUrl?> GetByShortUrlAsync(string shortUrl);
    Task<ShortUrl?> CreateAsync(CreateShortUrlDto createDto);
    Task<string?> GetOriginalUrlAsync(string shortUrl);
}