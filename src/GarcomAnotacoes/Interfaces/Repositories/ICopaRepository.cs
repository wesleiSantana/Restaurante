using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GarcomAnotacoes.Interfaces.Repositories
{
    public interface ICopaRepository : IRepository<Copa>
    {
        Task<IEnumerable<Copa>> ObeterCopaEPedidos();
    }
}
