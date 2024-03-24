using ThomasGreg_Domain.Entities;

namespace ThomasGreg_Domain.Repositories
{
    public interface ILogradouroRepository
    {
        void Adicionar(IEnumerable<Logradouro> logradouros);
        void Adicionar(Logradouro logradouro);
        void Atualizar(Logradouro logradouro);
        Logradouro Obter(int id);
        IEnumerable<Logradouro> ObterTodos();
        void Remover(int id);
    }
}