using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GTMDWebTool.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title="Login Page";
            return View();
        }
        public ActionResult Header()
        {
            ViewBag.Title = "Login Page";
            return View();
        }
    }
}
