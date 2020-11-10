using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using QuickBite.Pages.Models;
using QuickBite.Pages.Models.Data.Configurations;
using QuickBite.Pages.Models.Data;

namespace QuickBite.Data
{
    public class QuickBiteContext : DbContext
    {
         public DbSet<Product> Products { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=QuickBite.db");
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
    }
    }
}