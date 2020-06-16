using sportsx.core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace sportsx.cliente.domain
{
    public class Pessoa : Entity, IAggragateRoot
    {
        public string Nome { get; private set; }
        public string CEP { get; private set; }
        public string Email { get; private set; }
        public Classificacao Classificacao { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
        protected Pessoa() { }
        public Pessoa(string nome, string cep, string email, PessoaFisica pessoaFisica, ICollection<Telefone> telefones)
        {
            Nome = nome;
            CEP = cep;
            Email = email;
            PessoaFisica = pessoaFisica;
            Telefones = telefones;
        }

        public Pessoa(string nome, string cep, string email, PessoaJuridica pessoaJuridica, ICollection<Telefone> telefones)
        {
            Nome = nome;
            CEP = cep;
            Email = email;
            PessoaJuridica = pessoaJuridica;
            Telefones = telefones;
        }
        public Pessoa(string nome, string cep, string email, PessoaFisica pessoaFisica, PessoaJuridica pessoaJuridica, ICollection<Telefone> telefones)
        {
            Nome = nome;
            CEP = cep;
            Email = email;
            PessoaJuridica = pessoaJuridica;
            Telefones = telefones;
        }
    }
}
