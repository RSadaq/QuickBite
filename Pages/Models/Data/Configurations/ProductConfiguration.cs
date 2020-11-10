using QuickBite.Pages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QuickBite.Pages.Models.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
          public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.ImageName).HasColumnName("ImageFileName");
        }
    }
}