using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Data.ContextMap
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired().HasColumnName("name").HasColumnType("varchar(30)");
            builder.Property(u => u.Email).IsRequired().HasColumnName("email").HasColumnType("varchar(120)");
            builder.Property(u => u.Password).IsRequired().HasColumnName("password").HasColumnType("varchar(120)");
            builder.Property(u => u.IdProfile).IsRequired().HasColumnName("id_profile").HasColumnType("INT");
            builder.HasOne(u => u.Profile).WithMany(p => p.Users).HasForeignKey(u => u.IdProfile);            
        }
    }
}
