using OnlineShoping.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string Search)
        {
            HomeIndexViewModel model = new HomeIndexViewModel(); 
            return View(model.CreateModel(Search));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}