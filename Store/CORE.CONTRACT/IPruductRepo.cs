using Core.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contract
{
    public interface IAsyncPruductRepo : IAsyncRepository<Product>
    {
        Task<int> TotalCountAsyn(string category = null);
        Task<IEnumerable<Product>> GetProductsAsync(int pageSize = 4, int pageNumber = 1, string category = null);//string category,
        Task<IEnumerable<Product>> GetProductsbyParentcategoriAsync(int pageSize = 4, int pageNumber = 1, string category = null);//string category,

        Task<IEnumerable<Product>> searchBynameAsync(string name);
        
        Task<int> TotalCountSearchAsync(string name);
        Task<IEnumerable<Product>> GetProductsSearchAsync(int pageSize = 4, int pageNumber = 1, string name = null);//string category,

        ////
        Task<IEnumerable<Product>> GetReletionPruductAsync(int prcID);
        //Task<IEnumerable<Product>> GetProductByGategoriMainPageAsync(string categoriName);

        Task<IEnumerable<Product>> imgeForsingleAsync();
        Task<Product> GetSingleProductAsync(int ProductID);

        Task<IEnumerable<Product>> GetProductmainPageAsync(string place);


    }
}
