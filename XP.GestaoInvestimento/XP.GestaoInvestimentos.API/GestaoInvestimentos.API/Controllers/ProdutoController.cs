using GestaoInvestimentos.Services.Interface;
using HCor.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GestaoInvestimentos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        /// <summary>
        /// Lista todos os produtos
        /// </summary>
        /// <response code="200">Obtenção de produtos com sucesso</response>
        /// <response code="500">Retorna um erro interno</response>   
        [HttpGet]
        [Route("ObterProdutos")]
        [Authorize]
        public IActionResult ObterProdutos()
        {
            try
            {
                var vRetorno = _produtoService.ObterProdutos();
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