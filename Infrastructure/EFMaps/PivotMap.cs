using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EFMaps;

public class PivotMap : IEntityTypeConfiguration<Pivot>
{
    public void Configure(EntityTypeBuilder<Pivot> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.TimeFrame).IsRequired();
        builder.Property(p => p.HasTP);

        builder
            .HasOne(p => p.OriginCandle)
            .WithOne()
            .HasForeignKey<Pivot>(p => p.OriginCandleId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(p => p.CoverCandle)
            .WithOne()
            .HasForeignKey<Pivot>(p => p.CoverCandleId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}