using Microsoft.EntityFrameworkCore;
using RetailStoreDbContext.Models;

namespace RetailStoreDbContext.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=localhost\SQLEXPRESS;Database=RetailStoreDB;Trusted_Connection=True;TrustServerCertificate=True");
    }
}