using System;
using System.Threading.Tasks;
using GarcomAnotacoes.Models;

namespace GarcomAnotacoes.Interfaces.Services
{
    public interface ICopaService : IDisposable
    {
        Task<bool> Insert(Copa copa);
        Task<bool> Update(Copa copa);
        Task<bool> Delete(long id);
    }
}
