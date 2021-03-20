using System.Collections.Generic;

namespace GarcomAnotacoes.Models
{
    public class Copa : Entity
    {
        public string Nome { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }

}
