namespace Presentation.Setup.Startup;

public class MiddlewaresConfiguration : IStartupFilter
{
    public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
    => builder =>
    {
        builder.UseAuthentication();
        next(builder);
    };
    
}