using System;
using System.Collections.Generic;
using System.Text;
using KendoUIDemo.Moddleware.Configurations;
using KendoUIDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KendoUIDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ProductsConfiguration());
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}