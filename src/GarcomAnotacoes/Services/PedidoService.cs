using System.Threading.Tasks;
using GarcomAnotacoes.Models;
using GarcomAnotacoes.Interfaces.Services;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;              

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }   

        public async Task<bool> Insert(Pedido pedido)
        {
            await _pedidoRepository.Insert(pedido);
            return true;
        }

        public async Task<bool> Update(Pedido pedido)
        {
            await _pedidoRepository.Update(pedido);
            return true;
        }

        public async Task<bool> Delete(long id)
        {
            await _pedidoRepository.Delete(await _pedidoRepository.Select(id));
            return true;
        }

        public void Dispose()
        {
            _pedidoRepository?.Dispose();
        }
    }
}
