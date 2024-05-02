using XP.GestaoInvestimentos.Domain.Auth;

namespace XP.GestaoInvestimentos.Services
{
    public interface IUsuarioService
    {
        AuthenticateResponse Authenticate(UserAuth model);
    }
}
