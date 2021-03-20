using GarcomAnotacoes.Data;
using GarcomAnotacoes.Models;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Repositories
{
    public class CopaRepository : Repository<Copa>, ICopaRepository
    {
        public CopaRepository(Context context) : base(context)
        { }       
    }
}
