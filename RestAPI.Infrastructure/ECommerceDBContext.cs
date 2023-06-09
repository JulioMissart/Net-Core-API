﻿using Microsoft.EntityFrameworkCore;
using RestAPI.Domain.Categories;
using RestAPI.Domain.Products;
using RestAPI.Domain.Users;

namespace RestAPI.Infrastructure
{
    public class ECommerceDBContext : DbContext
    {
        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity(j => j.ToTable("Categories_Products"));
        }
    }
}
