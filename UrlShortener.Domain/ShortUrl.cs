namespace UrlShortener.Domain;

public sealed class ShortUrl : Entity
{
    public Guid Id { get; private init; }
    public string OriginalUrl { get; private set; }
    public string Url { get; private set; }

    public ShortUrl() { }

    private ShortUrl(string originalUrl)
    {
        OriginalUrl = originalUrl;
        Url = GenerateShortenedUrl(originalUrl);
        Id = Guid.NewGuid();
    }

    public static ShortUrl Create(string OriginalUrl)
    {
        var shortUrl = new ShortUrl(OriginalUrl);
        return shortUrl;
    }

    private string GenerateShortenedUrl(string baseUrl)
    {
        // TODO: define short url creation
        return baseUrl;
    }
}
