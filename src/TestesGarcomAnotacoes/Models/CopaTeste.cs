using Xunit;
using GarcomAnotacoes.Models;
using System.Collections.Generic;

namespace TestesGarcomAnotacoes.Models
{
    public class CopaTeste
    {
        [Fact]
        public void Models_CopaTeste_Construtor()
        {
            // Preparação
            long Id = 100;
            long PedidoId = 100;
            int NumeDaMesa = 10;
            int QuantidaDeBebidas = 1;
            int QuantidadeDePratos = 1;
            string NomeDaBabida = "Guaraná";
            string NomeDoPrato = "Macarrão na chapa";
            string NomeDocliente = "Weslei M Santana";

            // Execução
            List<Pedido> pedidos = new List<Pedido>();

            Pedido pedido = new Pedido
            {
                Id = Id,
                NumeDaMesa = NumeDaMesa,
                NomeDoPrato = NomeDoPrato,
                NomeDaBabida = NomeDaBabida,
                NomeDocliente = NomeDocliente,
                QuantidaDeBebidas = QuantidaDeBebidas,
                QuantidadeDePratos = QuantidadeDePratos
            };

            pedidos.Add(pedido);

            Copa copa = new Copa
            {
                Id = Id,
                Pedido = pedidos,
                PedidoId = PedidoId,
            };

            // Asserts

            Assert.Equal(copa.Id, Id);
            Assert.Equal(copa.Pedido, pedidos);
            Assert.Equal(copa.PedidoId, PedidoId);
        }
    }
}
