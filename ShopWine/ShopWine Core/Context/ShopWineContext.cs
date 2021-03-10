using Microsoft.AspNet.Identity.EntityFramework;
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
            Database.EnsureCreated();
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductProporties> ProductProporties { get; set; }
        public DbSet<History> Histories{ get; set; }
    }
}
