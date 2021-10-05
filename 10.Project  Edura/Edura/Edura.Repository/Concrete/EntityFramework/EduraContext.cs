﻿using Edura.Entity;
using Microsoft.EntityFrameworkCore;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EduraContext : DbContext
    {
        public EduraContext(DbContextOptions<EduraContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
       // public DbSet<Order> Orders { get; set; }

        //Model olusturulmadan evvel calistirilacak method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(pk => new { pk.ProductId, pk.CategoryId });
        }
    }
}