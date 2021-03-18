using Microsoft.AspNetCore.Mvc;

namespace GarcomAnotacoes.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
