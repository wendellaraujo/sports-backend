using sportsx.api.DTO;
using sportsx.cliente.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sportsx.api.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        public async Task<Pessoa> Adicionar(Pessoa pessoa)
        {
            var response = await _pessoaRepository.Adicionar(pessoa);
            return response;
        }

        public async Task<Pessoa> Atualizar(Pessoa pessoa)
        {
            var response = await _pessoaRepository.Atualizar(pessoa);
            return response;
        }

        public async Task<Pessoa> ObterPorId(int id)
        {
            return await _pessoaRepository.ObterPorId(id);
        }

        public async Task<IEnumerable<Pessoa>> ObterTodos()
        {
            return await _pessoaRepository.ObterTodos();
        }

        public async Task<Pessoa> Excluir(int id)
        {
            var response = await _pessoaRepository.Excluir(id);
            return response;
        }
    }
}
