using Moq;
using Xunit;
using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using GarcomAnotacoes.Services;
using System.Collections.Generic;
using GarcomAnotacoes.Interfaces.Repositories;

namespace TestesGarcomAnotacoes.Services
{
    public class CozinhaServiceTeste
    {
        [Fact]
        public async Task Services_CozinhaService_Adicionar_Pedido()
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

            //Cozinha cozinha = new Cozinha
            //{
            //    Id = Id,
            //    Pedido = pedidos,
            //};

            //// Execução         
            //Mock<ICozinhaRepository> repository = new Mock<ICozinhaRepository>();
            //CozinhaService cozinhaService = new CozinhaService(repository.Object);

            //bool resultDelete = await cozinhaService.Delete(Id);
            //bool resultInsert = await cozinhaService.Insert(cozinha);
            //bool resultUpdate = await cozinhaService.Update(cozinha);

            //// Asserts

            //Assert.True(resultDelete);
            //Assert.True(resultInsert);
            //Assert.True(resultUpdate);
        }
    }
}
