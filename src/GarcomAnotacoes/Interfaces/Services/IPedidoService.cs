using System;
using System.Threading.Tasks;
using GarcomAnotacoes.Models;

namespace GarcomAnotacoes.Interfaces.Services
{
    public interface IPedidoService : IDisposable
    {
        Task<bool> Insert(Pedido pedido);
        Task<bool> Update(Pedido pedido);
        Task<bool> Delete(long id);
    }
}
