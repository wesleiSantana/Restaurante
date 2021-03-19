using Xunit;
using GarcomAnotacoes.Models;
using System.Collections.Generic;

namespace TestesGarcomAnotacoes.Models
{
    public class CozinhaTeste
    {
        [Fact]
        public void Models_CozinhaTeste_Construtor()
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

            Cozinha cozinha = new Cozinha
            {
                Id = Id,
                Pedido = pedidos,
                PedidoId = PedidoId,
            };

            // Asserts

            Assert.Equal(cozinha.Id, Id);
            Assert.Equal(cozinha.Pedido, pedidos);
            Assert.Equal(cozinha.PedidoId, PedidoId);
        }
    }
}
