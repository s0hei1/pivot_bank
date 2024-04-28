using Presentation.Middlewares;

namespace Presentation.Setup.Startup;

public class MiddlewaresConfiguration : IStartupFilter
{
    public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
    => builder =>
    {
        builder.UseAuthentication();

        builder.UseMiddleware<CheckSomethingMiddleware>();
        
        var isDevelopment = Environment.GetEnvironmentVariable(EnvironmentVariables.IsDevelopment);
        
        next(builder);
    };
    
    
    
}