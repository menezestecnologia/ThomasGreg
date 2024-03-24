using ThomasGreg_Domain.Entities;

namespace ThomasGreg_Domain.Services
{
    public interface IClienteService
    {
        void Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        Cliente Obter(int id);
        Cliente Obter(string email);
        IEnumerable<Cliente> ObterTodos();
        void Remover(int id);
    }
}