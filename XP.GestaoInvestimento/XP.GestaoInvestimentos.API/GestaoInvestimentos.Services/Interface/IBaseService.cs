using GestaoInvestimentos.Domain;

namespace GestaoInvestimentos.Services.Interface
{
    public interface IBaseService<T>
    {
        Notification Cadastrar(T objeto);
        IEnumerable<T> Listar();
        T ObterPorId(Int32 id);
    }
}
