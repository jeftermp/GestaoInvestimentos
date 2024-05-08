using System.ComponentModel.DataAnnotations;
using GestaoInvestimentos.Domain.DataTaxonomy;

namespace GestaoInvestimentos.Domain.Auth
{
    public class UserAuth
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [PiiData]
        public string Password { get; set; }
    }
}