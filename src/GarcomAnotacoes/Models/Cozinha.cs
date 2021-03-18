using System.Collections.Generic;

namespace GarcomAnotacoes.Models
{
    public class Cozinha : Entity
    {
        public long PedidoId { get; set; }
        public IEnumerable<Pedido> Pedido { get; set; }
    }
}