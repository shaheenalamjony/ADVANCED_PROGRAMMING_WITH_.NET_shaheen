using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace week2LabcClass.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

            int a = 10;
            int b = 12;
            int c = a + b;

            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;

            string[] names = new string[3];

            names[0] = "shaheen ";
            names[1] = "tanvir ";
            names[2] = "sabbir ";

            ViewBag.Names = names;


            ViewData["x"] = a;
            ViewData["y"] = b;
            ViewData["z"] = c;

            ViewData["xyz"] = names; 

            return View();
        }
        public ActionResult studentList()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult teacherList()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     public ActionResult Profile()
            {
            //    ViewBag.Message = "Your contact page.";
            //ViewBag.Name = "shaheen";
            //ViewBag.Id = "1112";
            //ViewData["Name"] = "tanvir";

            
            

                return View();
            }
    public ActionResult Register()
        {
            //return Redirect("/home/profile");
            return RedirectToAction("Profile");
            //return RedirectToAction("Index","Home");
        }

    }
}