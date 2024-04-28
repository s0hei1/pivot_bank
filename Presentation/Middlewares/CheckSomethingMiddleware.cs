namespace Presentation.Middlewares;

public class CheckSomethingMiddaleware
{
    private readonly RequestDelegate _next;

    public CheckSomethingMiddaleware(RequestDelegate next)
    {
        _next = next;
    }
}