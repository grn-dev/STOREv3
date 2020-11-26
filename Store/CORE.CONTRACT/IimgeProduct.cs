using Core.Contract;
using CORE.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.CONTRACT
{
    public interface IimgeProduct : IRepository<imgeProduct>
    {
        List<imgeProduct> AddList(List<imgeProduct> entity);
    }
}
