using System.Collections.Generic;

namespace GarcomAnotacoes.Models
{
    public class Copa : Entity
    {
        public long PedidoId { get; set; }
        public IEnumerable<Pedido> Pedido { get; set; }
    }
}
