using Microsoft.EntityFrameworkCore;
using Ogorodik.DataProvider.Models;
using System;

namespace Ogorodik.DataProvider
{
    public class OgorodikDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public OgorodikDbContext(DbContextOptions<OgorodikDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}
