using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ogorodik.DataProvider.Identity;
using Ogorodik.DataProvider.Models;
using System;
using System.Reflection;

namespace Ogorodik.DataProvider
{
    public class OgorodikDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public OgorodikDbContext(DbContextOptions<OgorodikDbContext> options)
             : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
