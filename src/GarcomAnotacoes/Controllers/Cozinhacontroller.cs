using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GarcomAnotacoes.Interfaces.Services;

namespace GarcomAnotacoes.Controllers
{
    public class Cozinhacontroller : Controller
    {
    
        private readonly ICozinhaService _cozinhaService;

        public Cozinhacontroller( ICozinhaService cozinhaService)
        {           
            _cozinhaService = cozinhaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddCopa(Cozinha cozinha)
        {
            if (!ModelState.IsValid) return RedirectToAction(nameof(Index));

            if (!await _cozinhaService.Insert(cozinha)) return RedirectToAction(nameof(Index));

            return RedirectToAction(nameof(Index));
        }
    }
}
