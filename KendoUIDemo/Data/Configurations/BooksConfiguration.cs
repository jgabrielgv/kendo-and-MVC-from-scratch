using KendoUIDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KendoUIDemo.Data.Configurations
{
    public class BooksConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(p => p.BookId);

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(p => p.Author)
                .IsRequired()
                .HasMaxLength(80);
            builder.Property(p => p.Price)
                .IsRequired()
                .HasDefaultValue(0M);
            builder.Property(p => p.NumberOfPages)
                .IsRequired()
                .HasDefaultValue(0);

            builder.HasData(
                new Book[]
                {
                    new Book { BookId = 1, Title = "War and Peace", Author = "Tolstoy", Price = 19.95M, NumberOfPages = 900 },
                    new Book { BookId = 2, Title = "Anathem", Author = "Stephenson", Price = 9.95M, NumberOfPages = 550 },
                    new Book { BookId = 3, Title = "As I Lay Dying", Author = "Faulkner", Price = 5.50M, NumberOfPages = 325 },
                    new Book { BookId = 4, Title = "Brother K", Author = "Dostoyevsky", Price = 18.99M, NumberOfPages = 700 },
                });

            builder.ToTable("Book");
        }
    }
}
