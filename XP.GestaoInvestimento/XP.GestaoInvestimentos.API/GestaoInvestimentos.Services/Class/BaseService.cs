using Microsoft.Extensions.Configuration;
using GestaoInvestimentos.Domain;
using GestaoInvestimentos.Infrastructure.Repository.Interface;
using GestaoInvestimentos.Services.Interface;

namespace GestaoInvestimentos.Services.Class
{
    public class BaseService<T> : IBaseService<T>
    {
        protected readonly IBaseRepository<T> repository;
        private readonly IConfiguration _config;

        public BaseService(IBaseRepository<T> repository, IConfiguration config)
        {
            this.repository = repository;
            _config = config;
        }

        public virtual Notification Cadastrar(T objeto)
        {
            Notification notification = (objeto as IValidar).Validar();

            if (!notification.HasErrors())
                repository.Cadastrar(objeto);

            return notification;
        }
        public virtual IEnumerable<T> Listar()
        {
            return repository.Listar();
        }

        public virtual T ObterPorId(Int32 id)
        {
            return repository.ObterPorId(id);
        }
    }
}
