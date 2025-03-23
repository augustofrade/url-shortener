using Microsoft.AspNetCore.Mvc;
using UrlShortener.API.Dto;
using UrlShortener.API.Dto.ShortenedUrl;
using UrlShortener.API.Services;

namespace UrlShortener.API.Routes;

public static class ShortUrlRouter
{
    public static void MapShortUrlRoutes(this RouteGroupBuilder group)
    {
        group.MapGet("url/{urlCode}", async ([FromRoute] string urlCode, IShortUrlService shortUrlService) =>
        {
            string? originalUrl = await shortUrlService.GetOriginalUrlAsync(urlCode);
            return new Response<GetShortUrlResponse>(new GetShortUrlResponse(originalUrl));
        })
            .WithTags("Short Url")
            .WithDescription("Get base url from shortened url");
    }
}