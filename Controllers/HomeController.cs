using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Dynamic;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(Repository.BlogEntries);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Project()
        {
            return View(Repository.currentProjects);
        }

        public ActionResult CompletedProject()
        {
            return View(Repository.completedProjects);
        }

        public ActionResult FutureProject()
        {
            return View(Repository.futureProjects);
        }
    }
}