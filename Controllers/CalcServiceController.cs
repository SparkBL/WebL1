using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebL_1.Models;

namespace WebL_1.Controllers
{
    public class CalcServiceController : Controller
    {
       
        public string Index()
        {
            return "Meh";
        }

        public IActionResult Model()
        {
            var viewmodel = new CalcUnit();
            return View(viewmodel);
        }

        public IActionResult ServiceInjection()
        {
            ViewData["Title"] = "Service Injection";
            return View();
        }
        public IActionResult VData()
        {
            ViewData["CalcUnit"] = new CalcUnit();
            return View();
        }

        public IActionResult VBag()
        {
            ViewBag.CalcUnit = new CalcUnit();
            return View();
        }
    }
}