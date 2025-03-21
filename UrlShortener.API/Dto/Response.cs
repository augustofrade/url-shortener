namespace UrlShortener.API.Dto;

public class Response<T>
{
    public T? Data { get; private init; }
    public ErrorDetails? Error { get; set; }

    public Response(T? Data)
    {
        this.Data = Data;
    }
}
