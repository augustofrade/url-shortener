using Microsoft.EntityFrameworkCore;
using UrlShortener.Domain.Context;
using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.API.Repository;

internal sealed class ShortUrlRepository(ApplicationDbContext dbContext) : IShortUrlRepository
{
    public async Task<bool> CreateAsync(ShortUrl shortUrl)
    {
        try
        {
            await dbContext.ShortUrl.AddAsync(shortUrl);
            await SaveAsync();
            return true;
        }
        catch(Exception ex)
        {
            return false;
        }
    }

    public Task<ShortUrl?> GetByUrlAsync(string originalUrl)
    {
        return dbContext.ShortUrl.Where(u => u.OriginalUrl == originalUrl).FirstOrDefaultAsync();
    }

    public Task SaveAsync()
    {
        return dbContext.SaveChangesAsync();
    }
}
