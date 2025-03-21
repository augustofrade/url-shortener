using UrlShortener.API.Dto.Shortener;
using UrlShortener.API.Repository;
using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.API.Services;

internal class ShortUrlService(IShortUrlRepository shortUrlRepository) : IShortUrlService
{
    public async Task<ShortUrl?> CreateAsync(CreateShortUrlDto createDto)
    {
        ShortUrlConfiguration configuration;
        if (createDto.Configuration.ExpirationDate.HasValue)
            configuration = ShortUrlConfiguration.Create(createDto.Configuration.ExpirationDate, createDto.Configuration.Active);
        else
            configuration = ShortUrlConfiguration.CreateDefault(createDto.Configuration.Active);

        var shortUrl = ShortUrl.Create(createDto.Url, configuration);

        var success = await shortUrlRepository.CreateAsync(shortUrl);

        return success ? shortUrl : null;
    }

    public Task<ShortUrl?> GetByShortUrlAsync(string shortUrl)
    {
        return shortUrlRepository.GetByShortUrlAsync(shortUrl);
    }

    public async Task<string?> GetOriginalUrlAsync(string shortUrl)
    {
        var shortUrlEntity = await GetByShortUrlAsync(shortUrl);
        if (shortUrlEntity == null)
            return null;
        return shortUrlEntity.Configuration.IsAccessible ? shortUrlEntity.OriginalUrl : null;
    }
}
