using Microsoft.AspNetCore.Mvc;

namespace GestaoInvestimentos.API.Controllers
{
    public class InvestimentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
