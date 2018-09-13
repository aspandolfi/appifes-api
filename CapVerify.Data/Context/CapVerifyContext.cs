using CapVerify.Data.Mappings;
using CapVerify.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CapVerify.Data.Context
{
    public class CapVerifyContext : DbContext
    {
        public DbSet<TituloCapitalizacao> TitulosCapitalizacao { get; set; }
        public DbSet<UserIdentity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TituloCapitalizacaoMap());
            modelBuilder.ApplyConfiguration(new UserIdentityMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
