using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using GarcomAnotacoes.Interfaces.Services;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Services
{
    public class CozinhaService : ICozinhaService
    {

        private readonly ICozinhaRepository _cozinhaRepository;

        public CozinhaService(ICozinhaRepository cozinhaRepository)
        {
            _cozinhaRepository = cozinhaRepository;
        }

        public async Task<bool> Insert(Cozinha cozinha)
        {
            await _cozinhaRepository.Insert(cozinha);
            return true;
        }

        public async Task<bool> Update(Cozinha cozinha)
        {
            await _cozinhaRepository.Update(cozinha);
            return true;
        }

        public async Task<bool> Delete(long id)
        {
            await _cozinhaRepository.Delete(await _cozinhaRepository.Select(id));
            return true;
        }

        public void Dispose()
        {
            _cozinhaRepository?.Dispose();
        }
    }
}
