using System.Linq;
using GarcomAnotacoes.Data;
using GarcomAnotacoes.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GarcomAnotacoes.Interfaces.Repositories;

namespace GarcomAnotacoes.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly Context _context;

        protected Repository(Context context)
        {
            _context = context;
        }

        public virtual async Task<TEntity> Select(long id)
        {
            var result = await _context.Set<TEntity>().Where(c => c.Id == id).ToListAsync();

            return result.FirstOrDefault();
        }

        public virtual async Task<IEnumerable<TEntity>> Select()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public virtual async Task Insert(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await Save();
        }

        public virtual async Task Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await Save();
        }

        public virtual async Task Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await Save();
        }

        public virtual async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
