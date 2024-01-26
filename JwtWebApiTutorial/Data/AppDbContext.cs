using JwtWebApiTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtWebApiTutorial.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().HasKey(k => k.UserId);
            //modelBuilder.Entity<User>().HasNoKey();
        }
        public DbSet<User> Users { get; set; }
    }
}
