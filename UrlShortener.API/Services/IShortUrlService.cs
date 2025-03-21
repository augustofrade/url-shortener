using UrlShortener.API.Dto.Shortener;
using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.API.Services;

internal interface IShortUrlService
{
    Task<ShortUrl?> GetByUrlAsync(string baseUrl);
    Task<ShortUrl?> CreateAsync(CreateShortUrlDto createDto);
}