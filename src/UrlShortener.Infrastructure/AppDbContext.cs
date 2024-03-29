﻿using Microsoft.EntityFrameworkCore;
using UrlShortener.Core.Models.Entities;
using UrlShortener.Infrastructure.Configuration;

namespace UrlShortener.Infrastructure
{
	internal class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new CounterConfiguration());
			modelBuilder.ApplyConfiguration(new UrlEntityConfiguration());
		}

		public DbSet<UrlEntity> Urls { get; set; }

		public DbSet<CounterEntity> Counters { get; set; }
	}
}
