using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
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
                    productName = item.product.Name,
                    VisitDate = item.VisitTime,
                    IP=item.IP
                });
            }
            return View(logDetails);
        }

        public IActionResult ReviewAll()
        { 
            var LogMasterall = _LogMaster.GetAll();
            return View(LogMasterall);
        }


        public IActionResult btnResetLog()
        {
            var ResultLogMaster = _LogMaster.GetLogMasters();
            var masterAll = _LogMaster.GetAll();
            List<LogMaster> LogMasterBulk = new List<LogMaster>();
            foreach (var item in ResultLogMaster)
            {
                if (masterAll.Any(c => c.productID == item.productID))
                {
                    var productlog = masterAll.FirstOrDefault(c => c.productID == item.productID);
                    productlog.CountVisit += item.CountVisit;
                    
                    _LogMaster.Update(productlog);

                }
                else
                {
                    LogMaster logMaster = new LogMaster()
                    {
                        productID = item.productID,
                        CountVisit = item.CountVisit
                    };
                    LogMasterBulk.Add(logMaster); 
                }

            } 
            _LogMaster.insertBulk(LogMasterBulk);
            _LogDetails.DeleteAll();
            ViewBag.SuccessMessage = "<p>Success!</p>";
            
            return RedirectToAction("Index", "Review");
        }
    }
}
