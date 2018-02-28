﻿using AutomatedTellerMachine.ActionFilers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller

        // msdn ActionResult class
    {
        [MyLoggingFilter]
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("about-this-atm")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO : send message to HQ
            ViewBag.TheMessage = "Thanks, we got your message.";

            return View();
        }

        private string serial = "ASPNETMVC5ATM1";

        public ActionResult Serial(string letterCase)
        {
            if (letterCase == "lower") return Content(serial.ToLower());
            return Content(serial);
        }

        public ActionResult StatusCode(int codeNo) {
            ViewBag.Message = "Returning status codes";
            return new HttpStatusCodeResult(codeNo);
        }

        public ActionResult Json()
        {
            ViewBag.Message = "Returning some Json";
            return Json(new { name = "serial", value = serial },
                JsonRequestBehavior.AllowGet);
        }
    }
}