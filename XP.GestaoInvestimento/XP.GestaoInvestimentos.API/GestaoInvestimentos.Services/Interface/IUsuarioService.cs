using GestaoInvestimentos.Domain.Auth;

namespace GestaoInvestimentos.Services
{
    public interface IUsuarioService
    {
        public AuthenticateResponse Authenticate(UserAuth model);
    }
}
