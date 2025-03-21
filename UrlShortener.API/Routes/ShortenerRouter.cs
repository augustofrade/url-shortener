using Microsoft.AspNetCore.Mvc;
using UrlShortener.API.Dto;
using UrlShortener.API.Dto.Shortener;

namespace UrlShortener.API.Routes;

public static class ShortenerRouter
{
    public static void RegisterRoutes(WebApplication app)
    {
        app.MapPost("/shortener", ([FromBody] CreateShortUrlDto createDto) =>
        {
            return new Response<ShortUrlResponse>(new(createDto.Url));
        })
            .WithTags("Shortener")
            .WithDescription("Shortens the provided URL");
    }
}