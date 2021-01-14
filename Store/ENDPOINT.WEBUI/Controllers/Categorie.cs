using Core.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOINT.WEBUI.Controllers
{
    public class Categorie : Controller
    {
        private readonly IAsyncPruductRepo RepoPrc;
        public Categorie(IAsyncPruductRepo RepoPrc_)
        {
            RepoPrc = RepoPrc_;

        }



    }
}
