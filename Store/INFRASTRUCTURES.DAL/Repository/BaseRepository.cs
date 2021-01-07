using Core.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Dal.Repository
{
    public abstract class BaseRepository<TEntity> : IAsyncRepository<TEntity> where TEntity : class
    {
        private readonly ContextMed ctx;
        public BaseRepository(ContextMed biz)
        {
            ctx = biz;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            ctx.Set<TEntity>().Add(entity);
            await ctx.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            TEntity entityToDelete = ctx.Set<TEntity>().Find(id);
            ctx.Remove(entityToDelete);
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await ctx.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            //return await ctx.Set<TEntity>().FindAsync(id);
            var resutl = ctx.Set<TEntity>().FindAsync(id);
             
            return await resutl;
        }

        public async Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
