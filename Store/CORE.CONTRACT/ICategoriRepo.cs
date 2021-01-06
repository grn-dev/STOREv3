using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contract
{
    public interface ICategoriRepo:IRepository<Category>
    {
        Task<Category> GetByName(String catname);

        List<Category>GetCategorylevel1();
        List<Category> GetCategorylevel2();

        List<Category> GetCategorylevel2(string parentName);

    }
}
