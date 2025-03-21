using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.API.Dto.Shortener;

public record CreateShortUrlResponse(ShortUrl? ShortUrl);
