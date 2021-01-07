using AutoMapper;
using Core.Contract;
using CORE.CONTRACT;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOIN.API.Controllers
{
    public class Product : Controller
    {

        private readonly IAsyncPruductRepo RepoPrc;
        private readonly IAsyncCategoriRepo categoriRepo;
        private readonly IAsyncProductInfo ProductInfoREPO;
        private readonly IMapper _mapper;

        public Product(IAsyncPruductRepo RepoPrc_, IMapper mapper, IAsyncCategoriRepo categoriRepo_, IAsyncProductInfo ProductInfoREPO_)
        {
            RepoPrc = RepoPrc_;
            categoriRepo = categoriRepo_;
            ProductInfoREPO = ProductInfoREPO_;
            _mapper = mapper;
        }


        //[Route("api/[controller]")]
        //[HttpGet]
        //public async Task<ActionResult<Product>> Products(int ProductID)
        //{

        //    var res = RepoPrc.GetSingleProduct(ProductID);
        //    //List<string> TAGS = ProductInfoREPO.GetMoreInfo(ProductID, "TAG");
        //    //var relerted = RepoPrc.GetReletionPruduct(ProductID);
        //    //UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
        //    //var relertedmap = _mapper.Map<productSingleImage>(relerted);
        //    //var relertedmaps = _mapper.Map<List<Product>, List<productSingleImage>>(relerted);
        //    //productMultiImage image = new productMultiImage()
        //    //{
        //    //    AllImages = res.Images,
        //    //    Category = res.Category,
        //    //    Description = res.Description,
        //    //    id = res.ProductID,
        //    //    Name = res.Name,
        //    //    Tags = TAGS,
        //    //    RelatedProduct = relertedmaps

        //    //};
        //    return await View(res);
             
        //}

    }
}
