using System.Text.Json.Serialization;
using XP.GestaoInvestimentos.Domain.DataTaxonomy;

namespace XP.GestaoInvestimentos.Domain
{
    public class Usuario
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [SensitiveData]
        public string Username { get; set; }

        [PiiData]
        [JsonIgnore]
        public string Password { get; set; }
    }
}
