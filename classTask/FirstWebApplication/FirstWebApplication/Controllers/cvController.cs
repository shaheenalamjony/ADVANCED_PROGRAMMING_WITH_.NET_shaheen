using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class cvController : Controller
    {
        // GET: cv
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult about()
        {
            return View();
        }
        public ActionResult skills()
        {
            return View();
        }
         public ActionResult portfolio()
        {
            return View();
        }
         public ActionResult experience()
        {
            return View();
        }
         public ActionResult contact()
        {
            return View();
        }

    }
}