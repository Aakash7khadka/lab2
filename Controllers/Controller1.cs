using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Controllers
{
    public class Controller1 : Controller
    {
        public IActionResult Index()
        {
            string index_value = "Sending string to view.";
            return Content(index_value);
        }


        public IActionResult Detail(string detail)
        {
            return Content(detail);
        }
        public IActionResult Show()
        {
            ViewData["Name"] = "Texas International College";
            ViewBag.location = "Mitrapark";
            return View();
        }
    }
}
