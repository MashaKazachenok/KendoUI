using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestKendoUI.Models;

namespace TestKendoUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var students = new DataClasses1DataContext()
                .CommonStudents
                .Take(4)
                .Select(x => x.FirstName + " " + x.LastName)
                .ToList();
            var model = new ListStudentsViewModel();
            model.Students = students;

            return View(model);
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