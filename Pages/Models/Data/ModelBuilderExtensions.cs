using Microsoft.EntityFrameworkCore;
using QuickBite.Pages.Models;
using System.Data.SqlClient;

namespace QuickBite.Pages.Models.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 1,
                    Name = "Avocado sandwich",
                    Description = "A scrumptious, healthy sandwich with avocado, a protein of your choice and salad",
                    Price = 8.99m,
                    ImageName = "sandwich.jfif"
                },
                new Product
                {
                    Id = 2,
                    Name = "Salad",
                    Description = "A delicious salad with veggies of your choice, tossed to perfection",
                    Price = 9.99m,
                    ImageName = "salad.jfif"
                },
                new Product
                {
                    Id = 3,
                    Name = "Houmous wrap",
                    Description = "Houmous, olives, tahinina and veggies of your choice in a delicious wrap",
                    Price = 5.99m,
                    ImageName = "wrap.jfif"
                }
            );
                    return modelBuilder;
        }
        
    }
}