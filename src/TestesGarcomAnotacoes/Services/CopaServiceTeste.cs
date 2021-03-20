using Moq;
using Xunit;
using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using GarcomAnotacoes.Services;
using System.Collections.Generic;
using GarcomAnotacoes.Interfaces.Repositories;

namespace TestesGarcomAnotacoes.Services
{
    public class CopaServiceTeste
    {
        [Fact]
        public async Task Services_CopaService_Adicionar_Pedido()
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

            //Copa copa = new Copa
            //{
            //    Id = Id,
            //    Pedido = pedidos,              
            //};

            //// Execução         
            //Mock<ICopaRepository> repository = new Mock<ICopaRepository>();
            //CopaService copaService = new CopaService(repository.Object);

            //bool resultDelete = await copaService.Delete(Id);
            //bool resultInsert = await copaService.Insert(copa);
            //bool resultUpdate = await copaService.Update(copa);

            //// Asserts

            //Assert.True(resultDelete);
            //Assert.True(resultInsert);
            //Assert.True(resultUpdate);
        }
    }
}
