using System.Linq;
using GarcomAnotacoes.Data;
using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Repositories
{
    public class CopaRepository : Repository<Copa>, ICopaRepository
    {
        public CopaRepository(Context context) : base(context)
        { }


        public async Task<IEnumerable<Copa>> ObeterCopaEPedidos()
        {
            return await _context.Set<Copa>().AsNoTracking().Include(pedido => pedido.Pedidos).OrderByDescending(p => p.Id).ToListAsync();
        }
    }
}
