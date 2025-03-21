using Microsoft.AspNetCore.Mvc;
using UrlShortener.API.Dto;
using UrlShortener.API.Dto.Shortener;
using UrlShortener.API.Services;

namespace UrlShortener.API.Routes;

public static class ShortenerRouter
{
    public static void RegisterRoutes(WebApplication app)
    {
        app.MapPost("/shortener", async ([FromBody] CreateShortUrlDto createDto, IShortUrlService shortUrlService) =>
        {
            var shortUrl = await shortUrlService.CreateAsync(createDto);
            return new Response<CreateShortUrlResponse>(new(shortUrl));
        })
            .WithTags("Shortener")
            .WithDescription("Shortens the provided URL");
    }
}