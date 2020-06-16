using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sportsx.cliente.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace sportsx.cliente.data.Mappings
{
    public class PessoaFisicaMapping : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CPF)
                .IsRequired();


            builder.ToTable("PessoaFisicas");
        }
    }
}
