using Microsoft.EntityFrameworkCore;
using sportsx.cliente.domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sportsx.cliente.data.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly PessoaContext _context;

        public PessoaRepository(PessoaContext context)
        {
            _context = context;
        }

        public async Task<Pessoa> Adicionar(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();
            return pessoa;
        }

        public async Task<Pessoa> Atualizar(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            await _context.SaveChangesAsync();
            return pessoa;
        }

        public async Task<Pessoa> Excluir(int id)
        {
           var pessoa = await _context.Pessoas
                    .Include(p => p.PessoaFisica)
                    .Include(p => p.PessoaJuridica)
                    .Include(p => p.Telefones)
                    .SingleOrDefaultAsync(x => x.Id == id);

            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();
            return pessoa;

        }

        public async Task<Pessoa> ObterPorId(int id)
        {
            return await _context.Pessoas
                    .Include(p => p.PessoaFisica)
                    .Include(p => p.PessoaJuridica)
                    .Include(p => p.Telefones)
                    .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Pessoa>> ObterTodos()
        {
            return await _context.Pessoas
                .Include(p => p.PessoaFisica)
                .Include(p => p.PessoaJuridica)
                .Include(p => p.Telefones)
                .ToListAsync();
        }
    }
}
