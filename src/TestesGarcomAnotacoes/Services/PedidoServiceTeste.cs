using Moq;
using Xunit;
using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using GarcomAnotacoes.Services;
using GarcomAnotacoes.Interfaces.Repositories;

namespace TestesGarcomAnotacoes.Services
{
    public class PedidoServiceTeste
    {   

        [Fact]
        public async Task Services_PedidoService_Adicionar_Pedido()
        {
            // Preparação
            long Id = 100;
            int NumeDaMesa = 10;
            string NomeDoPrato = "Macarrão na chapa";
            string NomeDaBabida = "Guaraná";
            string NomeDocliente = "Weslei M Santana";
            int QuantidaDeBebidas = 1;
            int QuantidadeDePratos = 1;

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

            // Execução         
            Mock<IPedidoRepository> repository = new Mock<IPedidoRepository>();
            PedidoService pedidoService = new PedidoService(repository.Object);   

            bool resultDelete = await pedidoService.Delete(Id);
            bool resultInsert = await pedidoService.Insert(pedido);
            bool resultUpdate = await pedidoService.Update(pedido);

            // Asserts

            Assert.True(resultDelete);
            Assert.True(resultInsert);
            Assert.True(resultUpdate);
        }
    }
}
