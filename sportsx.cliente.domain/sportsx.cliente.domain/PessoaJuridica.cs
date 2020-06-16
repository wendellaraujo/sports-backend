using sportsx.core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace sportsx.cliente.domain
{
    public class PessoaJuridica : Entity
    {
        public string CNPJ { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
        protected PessoaJuridica() { }
        public PessoaJuridica(string cnpj)
        {
            CNPJ = cnpj;
        }

        public PessoaJuridica(int pessoaJuridicaId, int pessoaId, string cnpj)
        {
            Id = pessoaJuridicaId;
            PessoaId = pessoaId;
            CNPJ = cnpj;
        }
    }
}
