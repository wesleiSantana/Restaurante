using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GarcomAnotacoes.Interfaces.Services;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Controllers
{
    public class Copacontroller : Controller
    {
        private readonly ICopaService _copaService;
        private readonly ICopaRepository _copaRepository;  

        public Copacontroller(ICopaService copaService, ICopaRepository copaRepository)
        {
            _copaService = copaService;
            _copaRepository = copaRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _copaRepository.ObeterCopaEPedidos());
        }

        public async Task<IActionResult> CadastrarCopa(Copa copa) 
        {
            if (!ModelState.IsValid) return RedirectToAction(nameof(Index));

            if (!await _copaService.Insert(copa)) return RedirectToAction(nameof(Index));

            return RedirectToAction(nameof(Index));
        }
    }
}
