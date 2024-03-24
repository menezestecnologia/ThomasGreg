using System.Text.Json.Serialization;

namespace ThomasGreg_Domain.Entities
{
    public class Logradouro
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Endereço { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        [JsonIgnore]
        public bool Deletado { get; set; }
    }
}
