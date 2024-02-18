﻿using Microsoft.EntityFrameworkCore;
using StanimalisThriftShop.Models;

namespace StanimalisThriftShop.DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Jerseys", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Caps", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Collectibles", DisplayOrder = 3 }
            );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Francisco Lindor Gnome",
                Description = "From a Mets game giveaway.",
                ListPrice = 25,
            },
            new Product
            {
                Id = 2,
                Name = "Zack Wheeler Autographed Baseball LGM",
                Description = "Zack Wheeler signed my baseball in 2017 after his return from Tommy John",
                ListPrice = 179,
            });
    }
}
