using Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructures.Dal.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
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

                throw;
            }
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            Type typeParameterType = typeof(TEntity);
            var resutl= ctx.Set<TEntity>().Find(id);
            Type typeParameterType2 = typeof(TEntity);
            return resutl;


        }

        public IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>().AsQueryable();
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
