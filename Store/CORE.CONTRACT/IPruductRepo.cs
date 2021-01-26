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
        int TotalCount(string category = null);
        int TotalCountlvl2(string category = null);
        Task<IEnumerable<Product>> GetProductsAsync(int pageSize = 4, int pageNumber = 1, string category = null);//string category,
        Task<IEnumerable<Product>> GetProductsbyParentcategoriAsync(int pageSize = 4, int pageNumber = 1, string category = null);//string category,

        Task<IEnumerable<Product>> searchBynameAsync(string name);
        
        int TotalCountSearch(string name);
        Task<IEnumerable<Product>> GetProductsSearchAsync(int pageSize = 4, int pageNumber = 1, string name = null);//string category,

        ////
        Task<IEnumerable<Product>> GetReletionPruductAsync(int prcID);
        //Task<IEnumerable<Product>> GetProductByGategoriMainPageAsync(string categoriName);

        Task<IEnumerable<Product>> imgeForsingleAsync();
        Task<Product> GetSingleProductAsync(int ProductID);

        Product GetSingleProduct(int ProductID);
        IEnumerable<Product> GetReletionPruduct(int prcID);

        Task<IEnumerable<Product>> GetProductmainPageAsync(string place);
        IEnumerable<Product> GetProductmainPagev2(string place);


    }
}
