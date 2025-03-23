using UrlShortener.API.Dto.Shortener;
using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.API.Services;

internal interface IShortUrlService
{
    Task<ShortUrl?> GetByUrlCodeAsync(string urlCode);
    Task<ShortUrl?> CreateAsync(CreateShortUrlDto createDto);
    Task<string?> GetOriginalUrlAsync(string urlCode);
}