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

        Task<TEntity> AddAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(TEntity entity);

    }
}
