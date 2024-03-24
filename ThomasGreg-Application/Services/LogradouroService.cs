using ThomasGreg_Domain.Entities;
using ThomasGreg_Domain.Repositories;
using ThomasGreg_Domain.Services;

namespace ThomasGreg_Application.Services
{
    public class LogradouroService(ILogradouroRepository logradouroRepository) : ILogradouroService
    {
        private readonly ILogradouroRepository _logradouroRepository = logradouroRepository;

        public void Adicionar(IEnumerable<Logradouro> logradouros)
        {
            _logradouroRepository.Adicionar(logradouros);
        }

        public void Adicionar(Logradouro logradouro)
        {
            _logradouroRepository.Adicionar(logradouro);
        }

        public void Atualizar(Logradouro logradouro)
        {
            _logradouroRepository.Atualizar(logradouro);
        }

        public Logradouro Obter(int id)
        {
            return _logradouroRepository.Obter(id);
        }

        public IEnumerable<Logradouro> ObterTodos()
        {
            return _logradouroRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _logradouroRepository.Remover(id);
        }
    }
}
