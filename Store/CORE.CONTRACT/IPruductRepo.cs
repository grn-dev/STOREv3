using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contract
{
    public interface IPruductRepo:IRepository<Product>
    {
        int TotalCount(string category = null);
        List<Product> GetProducts( int pageSize = 4, int pageNumber = 1,string category=null );//string category,

        List<Product> searchByname(string name);
        int TotalCountSearch(string name);
        List<Product> GetProductsSearch(int pageSize = 4, int pageNumber = 1, string name = null);//string category,

        ////
        List<Product> GetReletionPruduct(Product prcID);
        List<Product> GetProductByGategoriMainPage(string categoriName);


    }
}
