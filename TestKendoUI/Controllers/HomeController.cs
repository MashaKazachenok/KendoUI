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
            List<string> students = new DataClasses1DataContext()
                .CommonStudents
                .Take(5)
                .Select(x => x.FirstName)
                .ToList();




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