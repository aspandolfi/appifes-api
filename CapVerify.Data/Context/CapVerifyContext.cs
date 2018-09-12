using CapVerify.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapVerify.Data.Context
{
    public class CapVerifyContext : DbContext
    {
        public DbSet<TituloCapitalizacao> TitulosCapitalizacao { get; set; }
        public DbSet<UserIdentity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
