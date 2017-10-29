using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Customers()
        //{
        //    ViewBag.Message = "List of customers goes here.";

        //    return View();
        //}

        //public ActionResult Movies()
        //{
        //    ViewBag.Message = "List of movies goes here.";
        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}