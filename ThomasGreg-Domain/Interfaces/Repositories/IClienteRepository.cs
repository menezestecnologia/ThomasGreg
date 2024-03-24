using ThomasGreg_Domain.Entities;

namespace ThomasGreg_Domain.Repositories
{
    public interface IClienteRepository
    {
        void Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        Cliente Obter(int id);
        Cliente Obter(string email);
        IEnumerable<Cliente> ObterTodos();
        void Remover(int id);
    }
}