using Data.Configuration;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
           // modelBuilder.ApplyConfiguration(new CountryData());
        }

        public DbSet<Country>? Countries { get; set; }
        public DbSet<CountryDetail>? CountryDetails { get; set; }
    }

}
