using Core.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contract
{
    public interface IAsyncCategoriRepo : IAsyncRepository<Category>
    {
         Task<Category>  GetByNameAsync(String catname);

        Task<ICollection<Category>> GetCategorylevel1Async();
        Task<IEnumerable<Category>> GetCategorylevel2Async();

        Task<IEnumerable<Category>> GetCategorylevel2Async(string parentName);

    }
}
