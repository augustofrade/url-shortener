using Microsoft.EntityFrameworkCore;
using UrlShortener.Domain.ShortUrls;

namespace UrlShortener.Domain.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<ShortUrl> ShortUrl { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShortUrl>().OwnsOne(e => e.Configuration);
    }
}
