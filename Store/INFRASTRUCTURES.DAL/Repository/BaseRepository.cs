using Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructures.Dal.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ContextMed ctx;
        public BaseRepository(ContextMed biz)
        {
            ctx = biz;
        }

        public TEntity Add(TEntity entity)
        {
            try
            {
                ctx.Set<TEntity>().Add(entity);
                ctx.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                return entity;
            }
            
        }

        public void Delete(int id)
        {
            TEntity entityToDelete = ctx.Set<TEntity>().Find(id);
            ctx.Remove(entityToDelete);
        }

        public TEntity Get(int id)
        {
            Type typeParameterType = typeof(TEntity);
            var resutl= ctx.Set<TEntity>().Find(id);
            Type typeParameterType2 = typeof(TEntity);
            return resutl;


        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>().AsQueryable();
        }

        public void Update(TEntity entity)
        { 
            ctx.Attach(entity);
            ctx.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges(); 
        }
    }
}
