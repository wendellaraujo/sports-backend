using AutoMapper;
using sportsx.api.DTO;
using sportsx.cliente.domain;
using System.Collections.Generic;

namespace sportsx.api.AutoMapper
{
    public class DtoToDomain : Profile
    {
        public DtoToDomain()
        {
            CreateMap<PessoaFisicaDTO, Pessoa>()
                .ConstructUsing(p => new Pessoa(p.Nome, p.CEP, p.Email, new PessoaFisica(p.PessoaFisicaId, p.PessoaId, p.CPF), new List<Telefone>()));

            CreateMap<PessoaJuridicaDTO, Pessoa>()
                .ConstructUsing(p => new Pessoa(p.Nome, p.CEP, p.Email, new PessoaJuridica(p.PessoaJuridicaId, p.PessoaId, p.CNPJ), new List<Telefone>()));

            CreateMap<TelefoneDTO, Telefone>()
                .ConstructUsing(p => new Telefone(p.Numero));
        }
    }
}
