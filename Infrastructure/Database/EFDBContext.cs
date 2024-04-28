using Domain.Core;
using Domain.Models;
using Infrastructure.EFMaps;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class EFDBContext : DbContext, IDbContext
{
    public DbSet<Candle> Candles { get; set; }
    public DbSet<Pivot> Pivots { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CandleMap());
        modelBuilder.ApplyConfiguration(new PivotMap());
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server= . ;Database=pivot_bank_db;Integrated Security = sspi;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
}
