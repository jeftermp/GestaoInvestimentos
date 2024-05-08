using Microsoft.Extensions.Configuration;
using GestaoInvestimentos.Domain;
using GestaoInvestimentos.Infrastructure.Context;
using GestaoInvestimentos.Infrastructure.Repository.Interface;

namespace GestaoInvestimentos.Infrastructure.Repository.Class
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly IConfiguration _config;
        private readonly InvestimentoContext contexto;

        public ClienteRepository(IConfiguration config, InvestimentoContext contexto) : base(contexto, config)
        {
            _config = config;
            this.contexto = contexto;
        }
    }
}
