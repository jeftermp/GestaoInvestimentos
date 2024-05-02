

namespace XP.GestaoInvestimentos.Infrastructure.Repository.Interface
{
    public interface IBaseRepository
    {
        void Cadastrar(T objeto);
        IEnumerable<T> Listar(Boolean? ativo = true);
        T ObterPorId(Int32 id);
        string GetConnString(string connectionSection);
    }
}
