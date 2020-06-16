using sportsx.cliente.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sportsx.api.DTO
{
    public class PessoaFisicaDTO
    {
        [Key]
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int PessoaFisicaId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }
        public string CEP { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Classificacao { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CPF { get; set; }
        public IEnumerable<TelefoneDTO> Telefones { get; set; }

    }
}
