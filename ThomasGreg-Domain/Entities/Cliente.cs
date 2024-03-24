using System.Text.Json.Serialization;

namespace ThomasGreg_Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string LogotipoBase64 { get; set; }
        public IEnumerable<Logradouro> Logradouros { get; set; }
        [JsonIgnore]
        public bool Deletado { get; set; }
    }
}
