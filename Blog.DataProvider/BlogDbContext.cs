using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blog.DataProvider.Identity;
using Blog.DataProvider.Models;
using System;
using System.Reflection;

namespace Blog.DataProvider
{
    public class BlogDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
             : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Post> Posts { get; set; }
    }
}
