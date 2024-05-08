using GestaoInvestimentos.Domain;

namespace GestaoInvestimentos.Services.Interface
{
    public interface IClienteService
    {
        public RetornoApi ObterClientes();
        public RetornoApi ObterClientePorId();
        public RetornoApi IncluirCliente();
        public RetornoApi AlterarCliente();
        public RetornoApi DeletarCliente();
    }
}