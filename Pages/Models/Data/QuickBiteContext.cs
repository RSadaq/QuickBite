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
            
             optionsBuilder.UseSqlServer("Server={Your Server Name};Initial Catalog={};Persist Security Info=False;User ID={Your UserID};Password={Your Password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
    }
    }
}