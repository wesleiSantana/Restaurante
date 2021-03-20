using System.Linq;
using GarcomAnotacoes.Data;
using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Repositories
{
    public class CozinhaRepository : Repository<Cozinha>, ICozinhaRepository
    {
        public CozinhaRepository(Context context) : base(context)
        { }

        public async Task<IEnumerable<Cozinha>> ObeterCozinhaEPedidos()
        {
            return await _context.Set<Cozinha>().AsNoTracking().Include(pedido => pedido.Pedidos).OrderByDescending(p => p.Id).ToListAsync();
        }
    }
}
