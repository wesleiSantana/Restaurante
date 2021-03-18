using System.Threading.Tasks;
using GarcomAnotacoes.Models;
using GarcomAnotacoes.Interfaces.Services;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Services
{
    public class CopaService : ICopaService
    {
        private readonly ICopaRepository _copaRepository;

        public CopaService(ICopaRepository copaRepository)
        {
            _copaRepository = copaRepository;
        }

        public async Task<bool> Insert(Copa copa)
        {
            await _copaRepository.Insert(copa);
            return true;
        }

        public async Task<bool> Update(Copa copa)
        {
            await _copaRepository.Update(copa);
            return true;
        }

        public async Task<bool> Delete(long id)
        {
            await _copaRepository.Delete(await _copaRepository.Select(id));
            return true;
        }

        public void Dispose()
        {
            _copaRepository?.Dispose();
        }
    }
}
