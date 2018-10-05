using KendoUIDemo.Data.Configurations;
using KendoUIDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KendoUIDemo.Data
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BooksConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Book> Books { get; set; }
    }
}
