using HCor.Helpers;
using Microsoft.Extensions.Configuration;
using GestaoInvestimentos.Domain;
using GestaoInvestimentos.Infrastructure.Repository.Interface;
using GestaoInvestimentos.Services.Interface;

namespace GestaoInvestimentos.Services.Class
{
    public class ClienteService : BaseService<Cliente> ,IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IConfiguration _config;

        public ClienteService(IClienteRepository clienteRepository, IConfiguration config) : base(clienteRepository, config)
        {
            _clienteRepository = clienteRepository;
            _config = config;
        }

        public RetornoApi AlterarCliente()
        {
            throw new NotImplementedException();
        }

        public RetornoApi DeletarCliente()
        {
            throw new NotImplementedException();
        }

        public RetornoApi IncluirCliente()
        {
            throw new NotImplementedException();
        }

        public RetornoApi ObterClientes()
        {
            try
            {
                var vListaClientes = _clienteRepository.Listar();

                return new RetornoApi
                {
                    Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    HasError = false,
                    Message = "Ok.",
                    Object = vListaClientes
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro on " + Utils.GetCurrentMethod() + ": " + ex.ToString());
                throw;
            }
        }

        public RetornoApi ObterClientePorId()
        {
            throw new NotImplementedException();
        }
    }
}