using System.Threading.Tasks;
using GarcomAnotacoes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using GarcomAnotacoes.Interfaces.Services;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ICopaService _copaService;
        private readonly IPedidoService _pedidoService;
        private readonly ICopaRepository _copaRepository;
        private readonly ICozinhaService _cozinhaService;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly ICozinhaRepository _cozinhaRepository;      

        public PedidoController(ICopaService copaService, IPedidoService pedidoService, ICopaRepository copaRepository, ICozinhaService cozinhaService, IPedidoRepository pedidoRepository, ICozinhaRepository cozinhaRepository)
        {
            _copaService = copaService;
            _pedidoService = pedidoService;
            _copaRepository = copaRepository;
            _cozinhaService = cozinhaService;
            _pedidoRepository = pedidoRepository;
            _cozinhaRepository = cozinhaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<SelectListItem> copas = new List<SelectListItem>();
            List<SelectListItem> cozinhas = new List<SelectListItem>();

            foreach (var value in await _copaRepository.Select()) copas.Add(new SelectListItem() { Text = value.Nome, Value = value.Id.ToString() });

            foreach (var value in await _cozinhaRepository.Select()) cozinhas.Add(new SelectListItem() { Text = value.Nome, Value = value.Id.ToString() });

            ViewBag.copas = copas;
            ViewBag.cozinhas = cozinhas;
            ViewBag.pedidos = await _pedidoRepository.Select();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastrarPedido(Pedido pedido)
        {
            if (!ModelState.IsValid) return RedirectToAction(nameof(Index));

            if (await _copaRepository.Select((long)pedido.CopaId) == null) return RedirectToAction(nameof(Index));

            if (await _cozinhaRepository.Select((long)pedido.CozinhaId) == null) return RedirectToAction(nameof(Index));

            if (!await _pedidoService.Insert(pedido)) return RedirectToAction(nameof(Index));  

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AlterarPedido(long id)
        {
            if (!ModelState.IsValid) return RedirectToAction(nameof(Index));

            var result = await _pedidoRepository.Select(id);

            if(result == null) return RedirectToAction(nameof(Index));

            result.Ativo = false;

            if (!await _pedidoService.Update(result)) return RedirectToAction(nameof(Index));

            return RedirectToAction(nameof(Index));
        }
    }
}
