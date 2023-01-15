using CrudOperationsEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperationsEntity.Controllers
{
    public class HomeController : Controller
    {
        StudentInfoEntities studentInfoEntities = new StudentInfoEntities();

        public ActionResult Index()
        {

            var data = studentInfoEntities.Students.ToList();

            return View(data);
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