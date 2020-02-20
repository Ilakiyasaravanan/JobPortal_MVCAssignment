using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobPortal_Entity;
using JobPortal_DAL;

namespace JobPortal_MVCAssignment.Controllers
{
    public class MainController : Controller
    {
       [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult SignUp()
        //{
        //    JobPersonDetails jobdetails = new JobPersonDetails();
        //    jobdetails.Add(jobdetails);
        //    ViewBag["Message"] = "Added";
        //    return View();
            
        //}
    }
}