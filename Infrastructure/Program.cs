using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EFDBContext>(
    options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection")
    );

var app = builder.Build();
app.Run();