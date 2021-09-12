using FESTA_FACIL.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FESTA_FACIL.Models.Mapeamento
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(a => a.id);
            builder.Property(a => a.id).ValueGeneratedOnAdd();
            builder.Property(a => a.Nome).HasMaxLength(35).IsRequired();
            builder.Property(a => a.Endereco).HasMaxLength(45).IsRequired();
            builder.Property(a => a.municipio).HasMaxLength(45).IsRequired();
            builder.Property(a => a.Contato).HasMaxLength(45).IsRequired();





        }
    }
}
