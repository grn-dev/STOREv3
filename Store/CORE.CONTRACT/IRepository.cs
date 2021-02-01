using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contract
{
    public interface IAsyncRepository<TEntity> where TEntity : class
    {

        Task<TEntity> GetAsync(int id);
        //List<TEntity> GetAll();
        Task<ICollection<TEntity>> GetAllAsync();
        IEnumerable<TEntity> GetAll();

        Task<TEntity> AddAsync(TEntity entity);
        TEntity Add(TEntity entity);
        Task DeleteAsync(int id);
        void Delete(int id);
        //Task UpdateAsync(TEntity entity);
        void Update(TEntity entity);

    }
}
