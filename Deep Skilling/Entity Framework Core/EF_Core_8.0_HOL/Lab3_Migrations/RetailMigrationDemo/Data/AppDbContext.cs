using Microsoft.EntityFrameworkCore;
using RetailMigrationDemo.Models;

namespace RetailMigrationDemo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        public DbSet<Category> Categories => Set<Category>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;Database=RetailMigrationDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}