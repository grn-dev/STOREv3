using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contract
{
    public interface ICategoriRepo:IRepository<Category>
    {
        Category GetByName(String catname);
    }
}
