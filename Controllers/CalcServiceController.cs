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
  
      
        public IActionResult Manual(int a, int b, int type)
        {
             if (Request.Method == "POST")
            {
                ViewData["Title"] = "Result";
                ViewBag.formShow = "none";
                CalcUnit c = new CalcUnit(a, b);
                ViewBag.result = "<h2>" + c.Action(type) + "</h2>";
                return View("Main");
            }
            ViewData["Title"] = "Manual";
            ViewBag.formShow = "block";
            return View("Main");
        }


        [HttpGet]
        public IActionResult ManualWithSeparateHandlers()
        {
            ViewData["Title"] = "Manual with separate handlers";
            ViewBag.formShow = "block";
            return View("Main");
        }


        [HttpPost]
        public IActionResult ManualWithSeparateHandlers(int a,int b, int type)
        {
            ViewData["Title"] = "Result";
            ViewBag.formShow = "none";
            CalcUnit c = new CalcUnit(a, b);
            ViewBag.result = "<h2>" + c.Action(type) + "</h2>";
            return View("Main");
        }
        [HttpGet]
        public IActionResult ModelBindingInParameters()
        {
            ViewData["Title"] = "Model binding in parameters";
            ViewBag.formShow = "block";
            return View("Main");
        }
        [HttpPost]
        public IActionResult ModelBindingInParameters([Bind("a", "b")] CalcUnit c, int type)
        {
            ViewData["Title"] = "Result";
            ViewBag.formShow = "none";
            ViewBag.result = "<h2>" + c.Action(type) + "</h2>";
            return View("Main");
        }

        [HttpGet]
        public IActionResult ModelBindingInSeparateModel()
        {
            ViewData["Title"] = "Model binding in separate model";
            ViewBag.formShow = "block";
            return View("Main");
        }
        [HttpPost]
        public IActionResult ModelBindingInSeparateModel(BindedCalcUnit bc)
        {
            ViewData["Title"] = "Result";
            ViewBag.formShow = "none";
            ViewBag.result = "<h2>" + bc.Action() + "</h2>";
            return View("Main");
        }
    }
}