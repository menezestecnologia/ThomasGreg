using ThomasGreg_Domain.Entities;
using ThomasGreg_Domain.Repositories;

namespace ThomasGreg_Repository.Repos
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly List<Cliente> Clientes = [];

        public void Adicionar(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void Remover(int id)
        {
            Clientes.Where(s => s.Id == id).ToList().ForEach(s =>
            {
                s.Deletado = true;
                s.Logradouros.ToList().ForEach(s => s.Deletado = true);
            });
        }

        public void Atualizar(Cliente cliente)
        {
            Clientes.Where(s => s.Id == cliente.Id).ToList().ForEach(s =>
            {
                s.Logradouros = cliente.Logradouros;
                s.LogotipoBase64 = cliente.LogotipoBase64;
                s.Email = cliente.Email;
                s.Nome = cliente.Nome;
            });
        }

        public Cliente Obter(int id)
        {
            return Clientes.FirstOrDefault(s => s.Id == id);
        }

        public Cliente Obter(string email)
        {
            return Clientes.FirstOrDefault(s => s.Email == email && !s.Deletado);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return Clientes.Where(s => !s.Deletado);
        }
    }
}
