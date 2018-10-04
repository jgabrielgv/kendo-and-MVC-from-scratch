using KendoUIDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KendoUIDemo.Moddleware.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductID);

            builder.Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(p => p.UnitPrice)
                .HasDefaultValue(0M);
            builder.Property(p => p.UnitsInStock)
                .HasDefaultValue(0M);
            builder.Property(p => p.UnitsOnOrder)
                .HasDefaultValue(0M);
            builder.Property(p => p.ReorderLevel)
                .HasDefaultValue(0M);
            builder.Property(p => p.Discontinued)
                .HasDefaultValue(0M);

            builder.ToTable("Products");
        }
    }
}