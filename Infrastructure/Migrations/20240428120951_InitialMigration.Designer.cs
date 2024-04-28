﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(EFDBContext))]
    [Migration("20240428120951_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Candle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Close")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("High")
                        .HasColumnType("float");

                    b.Property<double>("Low")
                        .HasColumnType("float");

                    b.Property<double>("Open")
                        .HasColumnType("float");

                    b.Property<int>("TimeFrame")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Candles");
                });

            modelBuilder.Entity("Domain.Models.Pivot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoverCandleId")
                        .HasColumnType("int");

                    b.Property<bool?>("HasTP")
                        .HasColumnType("bit");

                    b.Property<int>("OriginCandleId")
                        .HasColumnType("int");

                    b.Property<int>("TimeFrame")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoverCandleId")
                        .IsUnique();

                    b.HasIndex("OriginCandleId")
                        .IsUnique();

                    b.ToTable("Pivots");
                });

            modelBuilder.Entity("Domain.Models.Pivot", b =>
                {
                    b.HasOne("Domain.Models.Candle", "CoverCandle")
                        .WithOne()
                        .HasForeignKey("Domain.Models.Pivot", "CoverCandleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Models.Candle", "OriginCandle")
                        .WithOne()
                        .HasForeignKey("Domain.Models.Pivot", "OriginCandleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CoverCandle");

                    b.Navigation("OriginCandle");
                });
#pragma warning restore 612, 618
        }
    }
}
