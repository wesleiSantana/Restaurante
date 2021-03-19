using Xunit;
using GarcomAnotacoes.Models;

namespace TestesGarcomAnotacoes.Models
{
    public class PedidoTeste
    {    
        [Fact]
        public void Models_PedidoTeste_Construtor()
        {
            // Preparação
            long Id = 100;
            int NumeDaMesa = 10;
            int QuantidaDeBebidas = 1;
            int QuantidadeDePratos = 1;
            string NomeDaBabida = "Guaraná";
            string NomeDoPrato = "Macarrão na chapa";
            string NomeDocliente = "Weslei M Santana";

            // Execução
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

            // Asserts

            Assert.Equal(pedido.Id, Id);
            Assert.Equal(pedido.NumeDaMesa, NumeDaMesa);
            Assert.Equal(pedido.NomeDoPrato, NomeDoPrato);
            Assert.Equal(pedido.NomeDaBabida, NomeDaBabida);
            Assert.Equal(pedido.NomeDocliente, NomeDocliente);
            Assert.Equal(pedido.QuantidaDeBebidas, QuantidaDeBebidas);
            Assert.Equal(pedido.QuantidadeDePratos, QuantidadeDePratos);
        }

    }
}