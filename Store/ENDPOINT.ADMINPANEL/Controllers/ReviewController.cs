using CORE.CONTRACT;
using ENDPOINT.ADMINPANEL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOINT.ADMINPANEL.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly ILogDetails _LogDetails;
        private readonly ILogMaster _LogMaster;


        public ReviewController(ILogDetails LogDetails, ILogMaster LogMaster)
        {
            _LogDetails = LogDetails;
            _LogMaster = LogMaster;
        }
        public IActionResult Index()
        {
            List<LogDetailsViewModel> logDetails = new List<LogDetailsViewModel>();
            var re = _LogDetails.GetAll();
             
            foreach (var item in re)
            { 
                logDetails.Add(new LogDetailsViewModel()
                {
                    productName= item.product.Name,
                    VisitDate=item.VisitTime
                });
            }
            return View(logDetails);
        }
    }
}
