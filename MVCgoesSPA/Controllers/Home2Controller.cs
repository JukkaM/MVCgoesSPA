using MVCgoesSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCgoesSPA.Controllers
{
    public class Home2Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}