using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sportsx.cliente.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace sportsx.cliente.data.Mappings
{
    class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Telefones");
        }
    }
}
