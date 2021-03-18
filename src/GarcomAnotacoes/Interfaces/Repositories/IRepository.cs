using System;
using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GarcomAnotacoes.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<int> Save();
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
        Task Insert(TEntity entity);
        Task<TEntity> Select(long id);
        Task<IEnumerable<TEntity>> Select();
    }
}
