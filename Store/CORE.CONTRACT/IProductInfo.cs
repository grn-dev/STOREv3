using Core.Contract;
using CORE.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.CONTRACT
{
    public interface IProductInfo: IRepository<ProductInfo>
    {
        List<string> GetMoreInfo(int ProductID,string keyname);
        //void AddTagProuduct(int ProductID,string TagName);
    }
}
