﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Iteration_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult HowItWork()
        { 

            return View();
        }
        public ActionResult News()
        {


            return View();
        }
        public ActionResult Homepage()
        {


            return View();
        }

        public ActionResult Map()
        {


            return View();
        }

    

    }
}
