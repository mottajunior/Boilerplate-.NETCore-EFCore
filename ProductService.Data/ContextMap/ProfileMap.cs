using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Data.ContextMap
{
    public class ProfileMap : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.ToTable("profile");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasColumnName("name").HasColumnType("varchar(30)");            
        }
    }
}
