using System.ComponentModel.DataAnnotations;
using XP.GestaoInvestimentos.Domain.DataTaxonomy;

namespace XP.GestaoInvestimentos.Domain.Auth
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