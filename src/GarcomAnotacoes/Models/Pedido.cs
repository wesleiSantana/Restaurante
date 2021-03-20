
namespace GarcomAnotacoes.Models
{
    public class Pedido : Entity
    {
        public bool Ativo { get; set; } = true;
        public int NumeDaMesa { get; set; }
        public string NomeDoPrato { get; set; }
        public string NomeDaBabida { get; set; }
        public string NomeDocliente { get; set; }
        public int QuantidaDeBebidas { get; set; }
        public int QuantidadeDePratos { get; set; }

        // 1 : N => Cozinha : Pedidos
        public Copa Copa { get; set; }      
        public long CopaId { get; set; }
        public long CozinhaId { get; set; }
        public Cozinha Cozinha { get; set; }
    }
}
