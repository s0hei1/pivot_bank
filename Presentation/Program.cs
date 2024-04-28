using Presentation.Setup.Startup;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddTransient<IStartupFilter, MiddlewaresConfiguration>();


app.MapGet("/", () => "Hello World!");

app.Run();
