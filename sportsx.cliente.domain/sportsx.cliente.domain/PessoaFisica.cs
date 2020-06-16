using sportsx.core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace sportsx.cliente.domain
{
    public class PessoaFisica : Entity
    { 
        public string CPF { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
        protected PessoaFisica() { }
        public PessoaFisica(string cpf)
        {
            CPF = cpf;
        }
        public PessoaFisica(int id, int pessoaId, string cpf)
        {
            Id = id;
            PessoaId = pessoaId;
            CPF = cpf;
        }
    }
}
