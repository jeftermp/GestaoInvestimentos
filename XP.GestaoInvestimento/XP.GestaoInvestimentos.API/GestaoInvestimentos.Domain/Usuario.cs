using System.Text.Json.Serialization;
using GestaoInvestimentos.Domain.DataTaxonomy;

namespace GestaoInvestimentos.Domain
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
