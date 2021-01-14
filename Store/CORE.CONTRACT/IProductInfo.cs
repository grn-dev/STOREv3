using Core.Contract;
using Core.Domian;
using CORE.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.CONTRACT
{
    public interface IAsyncProductInfo : IAsyncRepository<ProductInfo>
    {
        Task<IEnumerable<string>> GetMoreInfoAsync(int ProductID,string keyname);
        IEnumerable<string> GetMoreInfo(int ProductID, string keyname);
        //void AddTagProuduct(int ProductID,string TagName);
        bool CheckExistAsync(int ProductID, string keyname,string Value);
        bool CheckExist(int ProductID, string keyname,string Value);
        Task<IEnumerable<Product>> GetProductByTagAsync(int pageSize = 4, int pageNumber = 1, string ProductName = null);
        int TotalCountSearchTag(string name);

    }
}
