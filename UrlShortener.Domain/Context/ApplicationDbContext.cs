using Microsoft.EntityFrameworkCore;

namespace UrlShortener.Domain.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<ShortUrl> ShortUrl { get; set; }
}
