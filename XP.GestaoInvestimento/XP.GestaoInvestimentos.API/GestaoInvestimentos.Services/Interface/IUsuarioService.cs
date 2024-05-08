using GestaoInvestimentos.Domain.Auth;

namespace GestaoInvestimentos.Services
{
    public interface IUsuarioService
    {
        AuthenticateResponse Authenticate(UserAuth model);
    }
}
