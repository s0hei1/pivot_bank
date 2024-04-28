using Application.HelperExtensions;

namespace Presentation.Middlewares;

public class CheckSomethingMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext httpContext)
    {
        
        var somethingHeader = httpContext.Request.Headers["Something"];

        if (string.IsNullOrWhiteSpace(somethingHeader).Not())
            throw new Exception();

        await next(httpContext);
    }
}