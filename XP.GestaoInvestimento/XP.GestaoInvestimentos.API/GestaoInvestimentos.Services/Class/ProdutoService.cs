using HCor.Helpers;
using Microsoft.Extensions.Configuration;
using GestaoInvestimentos.Domain;
using GestaoInvestimentos.Infrastructure.Repository.Interface;
using GestaoInvestimentos.Services.Interface;

namespace GestaoInvestimentos.Services.Class
{
    public class ProdutoService : BaseService<Produto> ,IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IConfiguration _config;

        public ProdutoService(IProdutoRepository produtoRepository, IConfiguration config) : base(produtoRepository, config)
        {
            _produtoRepository = produtoRepository;
            _config = config;
        }

        public RetornoApi AlterarProduto()
        {
            throw new NotImplementedException();
        }

        public RetornoApi DeletarProduto()
        {
            throw new NotImplementedException();
        }

        public RetornoApi IncluirProduto()
        {
            throw new NotImplementedException();
        }

        public RetornoApi ObterProdutoPorId()
        {
            throw new NotImplementedException();
        }

        public RetornoApi ObterProdutos()
        {
            try
            {
                var vListaProdutos = _produtoRepository.Listar();

                return new RetornoApi
                {
                    Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    HasError = false,
                    Message = "Ok.",
                    Object = vListaProdutos
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro on " + Utils.GetCurrentMethod() + ": " + ex.ToString());
                throw;
            }
        }
    }
}