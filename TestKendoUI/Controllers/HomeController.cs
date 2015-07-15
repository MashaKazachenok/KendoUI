using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestKendoUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<CommonStudent> students = new DataClasses1DataContext().CommonStudents.Take(5).ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}