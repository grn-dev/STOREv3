using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Contract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        
        TEntity Get(int id);
        //List<TEntity> GetAll();
        IQueryable<TEntity> GetAll();
        
        TEntity Add(TEntity entity);
        void Delete(int id);
        bool Update(TEntity entity);

    }
}
