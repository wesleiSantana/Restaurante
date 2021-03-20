using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GarcomAnotacoes.Interfaces.Repositories
{
    public interface ICozinhaRepository : IRepository<Cozinha>
    {
        Task<IEnumerable<Cozinha>> ObeterCozinhaEPedidos();

    }   
}
