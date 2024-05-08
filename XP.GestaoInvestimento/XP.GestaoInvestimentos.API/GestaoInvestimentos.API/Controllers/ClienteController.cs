using HCor.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using GestaoInvestimentos.Services.Interface;

namespace GestaoInvestimentos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        /// <summary>
        /// Lista todos os clientes
        /// </summary>
        /// <response code="200">Obtenção de clientes com sucesso</response>
        /// <response code="500">Retorna um erro interno</response>   
        [HttpGet]
        [Route("ObterClientes")]
        [Authorize]
        public IActionResult ObterClientes()
        {
            try
            {
                var vRetorno = _clienteService.ObterClientes();
                return Ok(vRetorno);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on " + Utils.GetCurrentMethod() + ": " + ex.ToString());
                return StatusCode((int)HttpStatusCode.InternalServerError, string.Format("{0} - {1}", ex.Message.ToString(), ex.StackTrace?.ToString()));
            }
        }
    }
}