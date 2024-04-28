using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<EFDBContext>(
    options => options.UseSqlServer(connectionString)
    );

var app = builder.Build();
app.Run();