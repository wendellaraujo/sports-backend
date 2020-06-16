using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sportsx.cliente.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace sportsx.cliente.data.Mappings
{
    class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Email)
                .IsRequired();

            builder.Property(p => p.Nome)
                .IsRequired();

            builder.HasMany(p => p.Telefones)
                .WithOne(c => c.Pessoa);

            builder.HasOne(p => p.PessoaJuridica)
                .WithOne(p => p.Pessoa);

            builder.HasOne(p => p.PessoaFisica)
                .WithOne(p => p.Pessoa);

            builder.ToTable("Pessoas");
        }
    }
}
