using AutoMapper;
using sportsx.api.DTO;
using sportsx.cliente.domain;

namespace sportsx.api.AutoMapper
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO()
        {
            CreateMap<Pessoa, PessoaFisicaDTO>()
                .ForPath(d => d.PessoaId, o => o.MapFrom(s => s.PessoaFisica.PessoaId))
                .ForPath(d => d.CPF, o => o.MapFrom(s => s.PessoaFisica.CPF))
                .ForPath(d => d.PessoaFisicaId, o => o.MapFrom(s => s.PessoaFisica.Id));

            CreateMap<Pessoa, PessoaJuridicaDTO>()
                .ForPath(d => d.CNPJ, o => o.MapFrom(s => s.PessoaJuridica.CNPJ))
                .ForPath(d => d.PessoaId, o => o.MapFrom(s => s.PessoaJuridica.PessoaId))
                .ForPath(d => d.PessoaJuridicaId, o => o.MapFrom(s => s.PessoaJuridica.Id));

            CreateMap<Pessoa, PessoaDTO>()
                .ForPath(d => d.CPF, o => o.MapFrom(s => s.PessoaFisica.CPF))
                .ForPath(d => d.CNPJ, o => o.MapFrom(s => s.PessoaJuridica.CNPJ));

            CreateMap<Telefone, TelefoneDTO>();
        }
    }
}
