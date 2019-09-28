using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserService.Infra.ContextMap
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).IsRequired().HasColumnName("nome").HasColumnType("varchar(30)");
            builder.Property(u => u.Email).IsRequired().HasColumnName("email").HasColumnType("varchar(120)");            
        }
    }
}
