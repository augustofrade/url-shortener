namespace UrlShortener.Domain.ShortUrls;

public sealed class ShortUrlConfiguration
{
    public DateTime? ExpirationDate { get; private set; }
    public bool Active { get; set; }

    public ShortUrlConfiguration() { }

    private ShortUrlConfiguration(DateTime? expirationDate, bool active)
    {
        SetExpirationDate(expirationDate);
        Active = active;
    }

    public bool IsExpired => ExpirationDate.HasValue && DateTime.UtcNow.CompareTo(ExpirationDate.Value) >= 0;

    public bool IsAccessible => !IsExpired && Active;

    public void SetExpirationDate(DateTime? expirationDate)
    {
        if(expirationDate.HasValue && DateTime.UtcNow.CompareTo(expirationDate.Value) <= 0)
        {
            throw new InvalidOperationException("Expiration date and time cannot be before current date and time");
        }
        ExpirationDate = expirationDate;
    }

    public static ShortUrlConfiguration Create(DateTime? expirationDate, bool enabled)
    {
        return new(expirationDate, enabled);
    }

    public static ShortUrlConfiguration CreateDefault(bool enabled)
    {
        return new(null, enabled);
    }
}
