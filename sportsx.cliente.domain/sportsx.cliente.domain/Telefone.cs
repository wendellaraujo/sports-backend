using sportsx.core.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sportsx.cliente.domain
{
    public class Telefone : Entity
    {
        public string Numero { get; set; }
        public Pessoa Pessoa { get; set; }
        
        public int PessoaId { get; set; }
        public Telefone() { }
        public Telefone(string numero)
        {
            Numero = numero;
        }
    }
}
