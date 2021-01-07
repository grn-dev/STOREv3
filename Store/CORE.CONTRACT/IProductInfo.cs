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
        Task<ICollection<string>> GetMoreInfoAsync(int ProductID,string keyname);
        //void AddTagProuduct(int ProductID,string TagName);
        bool CheckExistAsync(int ProductID, string keyname,string Value);
        Task<IEnumerable<GetProductByTag>> GetProductByTagAsync(int pageSize = 4, int pageNumber = 1, string ProductName = null);



    }
}
