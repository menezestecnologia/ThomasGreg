using ThomasGreg_Domain.Entities;
using ThomasGreg_Domain.Repositories;

namespace ThomasGreg_Repository.Repos
{
    public class LogradouroRepository : ILogradouroRepository
    {
        private readonly List<Logradouro> Logradouros = [];

        public void Adicionar(IEnumerable<Logradouro> logradouros)
        {
            foreach (var logradouro in logradouros)
            {
               Adicionar(logradouro);
            }
        }

        public void Adicionar(Logradouro logradouro)
        {
            Logradouros.Add(logradouro);
        }

        public void Remover(int id)
        {
            Logradouros.Where(s => s.Id == id).ToList().ForEach(s => s.Deletado = true);
        }

        public void Atualizar(Logradouro logradouro)
        {
            Logradouros.Where(s => s.Id == logradouro.Id).ToList().ForEach(s =>
            {
                s.Endereço = logradouro.Endereço;
                s.Bairro = logradouro.Bairro;
                s.Complemento = logradouro.Complemento;
                s.Cidade = logradouro.Cidade;
                s.Estado = logradouro.Estado;
            });
        }

        public Logradouro Obter(int id)
        {
            return Logradouros.FirstOrDefault(s => s.Id == id && !s.Deletado);
        }

        public IEnumerable<Logradouro> ObterTodos()
        {
            return Logradouros.Where(s => !s.Deletado);
        }
    }
}
