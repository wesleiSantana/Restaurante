using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GarcomAnotacoes.Interfaces.Services;

namespace GarcomAnotacoes.Controllers
{
    public class Copacontroller : Controller
    {
        private readonly ICopaService _copaService;
       

        public Copacontroller(ICopaService copaService)
        {
            _copaService = copaService;           
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddCopa(Copa copa) 
        {
            if (!ModelState.IsValid) return RedirectToAction(nameof(Index));

            if (!await _copaService.Insert(copa)) return RedirectToAction(nameof(Index));

            return RedirectToAction(nameof(Index));
        }
    }
}
