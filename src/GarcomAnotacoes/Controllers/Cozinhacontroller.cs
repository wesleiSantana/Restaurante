using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GarcomAnotacoes.Interfaces.Services;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Controllers
{
    public class Cozinhacontroller : Controller
    {   
        private readonly ICozinhaService _cozinhaService;     
        private readonly ICozinhaRepository _cozinhaRepository;

        public Cozinhacontroller(ICozinhaService cozinhaService, ICozinhaRepository cozinhaRepository)
        {
            _cozinhaService = cozinhaService;
            _cozinhaRepository = cozinhaRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _cozinhaRepository.ObeterCozinhaEPedidos());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastrarcozinha(Cozinha cozinha) 
        {
            if (!ModelState.IsValid) return RedirectToAction(nameof(Index));

            if (!await _cozinhaService.Insert(cozinha)) return RedirectToAction(nameof(Index));

            return RedirectToAction(nameof(Index));
        }    
    }
}
