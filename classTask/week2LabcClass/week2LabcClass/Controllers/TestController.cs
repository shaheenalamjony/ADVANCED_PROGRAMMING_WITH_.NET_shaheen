using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace week2LabcClass.Controllers
{
    public class TestController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentList()
        {
            int SchoolId = 10290;
            string SchoolName = "shaheen school";

            //using ViewBag
            ViewBag.sId = SchoolId;
            ViewBag.sName=SchoolName;

            //using viewData
            ViewData["scId"] = SchoolId;
            ViewData["scName"] = SchoolName;


            string[] StudentDetails = new string[3];
            StudentDetails[0] = "1";
            StudentDetails[1] = "shaheen";
            StudentDetails[2] = "CSE";

            //array store in ViewBag
            ViewBag.details=StudentDetails;


            return View();
        }
    }
}