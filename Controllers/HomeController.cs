using PTCData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            TrainingProductViewModel vm = new TrainingProductViewModel();
            vm.HandleRequest();
            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(TrainingProductViewModel vm)
        {
            vm.IsValid = ModelState.IsValid;
            vm.HandleRequest();
            if (vm.IsValid)
            {
                ModelState.Clear();
            }
            
            return View(vm);
        }
    }
}