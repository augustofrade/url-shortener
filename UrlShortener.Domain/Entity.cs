namespace UrlShortener.Domain;

public class Entity
{
    public DateTime CreatedAt { get; private init; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
