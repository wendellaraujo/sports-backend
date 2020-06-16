using sportsx.cliente.domain;
using System.Collections.Generic;

namespace sportsx.api.DTO
{
    public class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Classificacao { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public IEnumerable<TelefoneDTO> Telefones { get; set; }
    }
}
