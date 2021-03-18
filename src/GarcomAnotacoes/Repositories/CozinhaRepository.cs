using GarcomAnotacoes.Data;
using GarcomAnotacoes.Models;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Repositories
{
    public class CozinhaRepository : Repository<Cozinha>, ICozinhaRepository
    {
        public CozinhaRepository(Context context) : base(context)
        { }
    }
}
