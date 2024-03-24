using ThomasGreg_Domain.Entities;
using ThomasGreg_Domain.Repositories;
using ThomasGreg_Domain.Services;
using System.Linq;

namespace ThomasGreg_Application.Services
{
    public class ClienteService(IClienteRepository clienteRepository, ILogradouroRepository logradouroRepository) : IClienteService
    {
        private readonly IClienteRepository _clienteRepository = clienteRepository;
        private readonly ILogradouroRepository _logradouroRepository = logradouroRepository;

        public void Adicionar(Cliente cliente)
        {
            cliente.Deletado = false;
            cliente.Logradouros.ToList().ForEach(s => s.Deletado = false);

            _logradouroRepository.Adicionar(cliente.Logradouros);
            _clienteRepository.Adicionar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _clienteRepository.Atualizar(cliente);
        }

        public Cliente Obter(int id)
        {
            return _clienteRepository.Obter(id);
        }

        public Cliente Obter(string email)
        {
            return _clienteRepository.Obter(email);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _clienteRepository.Remover(id);
        }
    }
}
