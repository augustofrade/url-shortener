namespace UrlShortener.Domain.ShortUrls;

public sealed class ShortUrl : Entity
{
    public Guid Id { get; private init; }
    public string OriginalUrl { get; private set; }
    public string UrlCode { get; private set; }

    public ShortUrlConfiguration Configuration { get; init; }

    public ShortUrl() { }

    private ShortUrl(string originalUrl, ShortUrlConfiguration configuration)
    {
        OriginalUrl = originalUrl;
        UrlCode = GenerateShortenedUrl(originalUrl);
        Id = Guid.NewGuid();
        Configuration = configuration;
    }

    public static ShortUrl Create(string originalUrl, ShortUrlConfiguration configuration)
    {
        var shortUrl = new ShortUrl(originalUrl, configuration);
        return shortUrl;
    }

    private string GenerateShortenedUrl(string baseUrl)
    {
        // TODO: define short url creation
        return baseUrl;
    }
}
