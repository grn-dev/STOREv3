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
        private readonly IPruductRepo RepoPrc;
        public Categorie(IPruductRepo RepoPrc_)
        {
            RepoPrc = RepoPrc_;
        }



    }
}
