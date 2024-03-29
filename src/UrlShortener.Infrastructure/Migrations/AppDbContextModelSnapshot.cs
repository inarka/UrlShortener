﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UrlShortener.Infrastructure;

#nullable disable

namespace UrlShortener.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UrlShortener.Core.Models.Entities.CounterEntity", b =>
                {
                    b.Property<Guid>("DefaultValue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CurrentValue")
                        .IsConcurrencyToken()
                        .HasColumnType("integer");

                    b.HasKey("DefaultValue");

                    b.ToTable("Counters");

                    b.HasData(
                        new
                        {
                            DefaultValue = new Guid("1e44280f-1fcf-4398-a923-9431afa95e29"),
                            CurrentValue = 0
                        });
                });

            modelBuilder.Entity("UrlShortener.Core.Models.Entities.UrlEntity", b =>
                {
                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<string>("OriginalUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("QrCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Token");

                    b.HasIndex("OriginalUrl");

                    b.ToTable("Urls");
                });
#pragma warning restore 612, 618
        }
    }
}
