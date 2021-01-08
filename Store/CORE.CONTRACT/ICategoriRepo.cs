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

        IEnumerable<Category> GetCategorylevel1();
        IEnumerable<Category> GetCategorylevel2();

        IEnumerable<Category> GetCategorylevel2Async(string parentName);

    }
}
