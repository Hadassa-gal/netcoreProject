using System;
using System.Reflection;
using Domain.entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.data;

public class superShopDBContext : DbContext
{
    public DbSet<Product> Products { get; set; } = default!;
    public DbSet<Category> Categories { get; set; } = default!;
    public DbSet<Brand> Brands { get; set; } = default!;
    public DbSet<Customer> Customers { get; set; } = default!;

    public superShopDBContext(DbContextOptions<superShopDBContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
    }
}
