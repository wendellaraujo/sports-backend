using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sportsx.cliente.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace sportsx.cliente.data.Mappings
{
    public class PessoaJuridicaMapping : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CNPJ)
                .IsRequired();


            builder.ToTable("PessoaJuridicas");
        }
    }
}
