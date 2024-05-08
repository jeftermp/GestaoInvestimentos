using GestaoInvestimentos.Domain;

namespace GestaoInvestimentos.Services.Interface
{
    public interface IProdutoService
    {
        public RetornoApi ObterProdutos();
        public RetornoApi ObterProdutoPorId();
        public RetornoApi IncluirProduto();
        public RetornoApi AlterarProduto();
        public RetornoApi DeletarProduto();
    }
}