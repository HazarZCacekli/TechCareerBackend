using Day6_EFC.Models;
using Microsoft.EntityFrameworkCore;

namespace Day6_EFC.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=FOCACEKLI\\SQLEXPRESS;Initial Catalog=TechCareer_SportsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Player>().Property(x => x.Price).HasPrecision(12, 2);
        }

        public DbSet<Player> Players { get; set; }
    }
}
