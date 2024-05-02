using Microsoft.AspNetCore.Mvc;

namespace XP.GestaoInvestimentos.API.Controllers
{
    public class InvestimentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
