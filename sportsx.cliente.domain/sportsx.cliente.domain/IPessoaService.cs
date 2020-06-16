using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sportsx.cliente.domain
{
    public interface IPessoaService
    {
        Task<IEnumerable<Pessoa>> ObterTodos();
        Task<Pessoa> ObterPorId(int id);

        Task<Pessoa> Adicionar(Pessoa pessoa);
        Task<Pessoa> Atualizar(Pessoa pessoa);
        Task<Pessoa> Excluir(int id);
    }
}
