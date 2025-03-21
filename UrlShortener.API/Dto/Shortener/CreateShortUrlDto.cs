namespace UrlShortener.API.Dto.Shortener;

internal record CreateShortUrlDto(string Url, CreateShortUrlConfigurationDto Configuration);

internal record CreateShortUrlConfigurationDto(DateTime? ExpirationDate, bool Active);