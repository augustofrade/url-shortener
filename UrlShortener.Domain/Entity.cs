namespace UrlShortener.Domain;

public class Entity
{
    public DateTime CreatedAt { get; private init; }
    public DateTime UpdatedAt { get; set; }
}
