using System;
using System.Threading.Tasks;
using GarcomAnotacoes.Models;

namespace GarcomAnotacoes.Interfaces.Services
{
    public interface ICozinhaService : IDisposable
    {
        Task<bool> Insert(Cozinha cozinha);
        Task<bool> Update(Cozinha cozinha);
        Task<bool> Delete(long id);
    }
}
