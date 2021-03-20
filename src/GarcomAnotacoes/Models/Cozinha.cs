﻿using System.Collections.Generic;

namespace GarcomAnotacoes.Models
{
    public class Cozinha : Entity
    {
        public string Nome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } 
    }
}