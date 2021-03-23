using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopWine_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWine_Core.Context
{
    public class ShopWineContext : IdentityDbContext<User, Role, Guid>
    {
        public ShopWineContext(DbContextOptions<ShopWineContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductProporties> ProductProporties { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Category>()
            .HasOne<Product>(p => p.Product)
            .WithOne(ca => ca.Category)
            .HasForeignKey<Product>(pr => pr.CategoryId);
            base.OnModelCreating(builder);
        }
    }
}
