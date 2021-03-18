using GarcomAnotacoes.Data;
using GarcomAnotacoes.Models;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Repositories
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(Context context) : base(context)
        { }
    }
}
