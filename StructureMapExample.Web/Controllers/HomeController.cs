using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StructureMapExample.Core;

namespace StructureMapExample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISampleClass _sampleClass;

        public HomeController(
            ISampleClass sampleClass)
        {
            _sampleClass = sampleClass;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = _sampleClass.GetAString();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}