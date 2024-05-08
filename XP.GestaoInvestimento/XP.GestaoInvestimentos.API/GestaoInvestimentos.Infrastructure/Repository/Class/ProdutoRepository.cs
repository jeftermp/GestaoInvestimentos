using Microsoft.Extensions.Configuration;
using GestaoInvestimentos.Domain;
using GestaoInvestimentos.Infrastructure.Context;
using GestaoInvestimentos.Infrastructure.Repository.Interface;

namespace GestaoInvestimentos.Infrastructure.Repository.Class
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly IConfiguration _config;
        private readonly InvestimentoContext contexto;

        public ProdutoRepository(IConfiguration config, InvestimentoContext contexto) : base(contexto, config)
        {
            _config = config;
            this.contexto = contexto;
        }
    }
}
