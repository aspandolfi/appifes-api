using CapVerify.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapVerify.Data.Mappings
{
    public class UserIdentityMap : IEntityTypeConfiguration<UserIdentity>
    {
        public void Configure(EntityTypeBuilder<UserIdentity> builder)
        {
            builder.ToTable("AspNetUsers");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnName("Id")
                .HasColumnType("nvarchar")
                .HasMaxLength(450);

            builder.Property(x => x.UserName)
                .HasColumnType("nvarchar")
                .HasMaxLength(256);

            builder.Property(x => x.Email)
                .HasColumnType("nvarchar")
                .HasMaxLength(256);
        }
    }
}
