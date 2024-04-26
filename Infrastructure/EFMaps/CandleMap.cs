using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.EFMaps;

public class CandleMap : IEntityTypeConfiguration<Candle>
{
    public void Configure(EntityTypeBuilder<Candle> builder)
    {
        
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Open).IsRequired();
        builder.Property(c => c.Close).IsRequired();
        builder.Property(c => c.High).IsRequired();
        builder.Property(c => c.Low).IsRequired();
        builder.Property(c => c.DateTime).IsRequired();
        builder.Property(c => c.TimeFrame).IsRequired();
    }
}