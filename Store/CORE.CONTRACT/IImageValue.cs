﻿using Core.Contract;
using CORE.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.CONTRACT
{
    public interface IAsyncImageValue : IAsyncRepository<ImageProduct>
    {
        //List<ImageProduct> AddList(List<ImageProduct> entity);
    }
}
