using DAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAS.Controllers
{
    public class HomeController : Controller
    {
        //5 pages 
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }

        public ActionResult  ourwork()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Appointment()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Appointment(apt a)
        {
            apt m = new apt();
           int effectedRows= m.Insert(a);
            if (effectedRows > 0)
            {
                ViewBag.SuccessMessage = "Appointment Booked ! ";
            }
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}