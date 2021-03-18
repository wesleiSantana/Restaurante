namespace GarcomAnotacoes.Models
{
    public class Pedido : Entity
    {
        public int NumeDaMesa { get; set; }
        public string NomeDoPrato { get; set; }
        public string NomeDaBabida { get; set; }
        public string NomeDocliente { get; set; }
        public int QuantidaDeBebidas { get; set; }
        public int QuantidadeDePratos { get; set; }
    }
}
