using MVCgoesSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCgoesSPA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var spas = new Repository().GetAllSpas();
            return View(spas);
        }

        public ActionResult Spa(int id)
        {
            var spa = new Repository().GetAllSpas().Skip(id - 1).First();

            return View(spa);
        }
    }
}