using lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Controllers
{
    public class Controller2 : Controller
    {
        public IActionResult Index()
        {
            ViewBag.id = 5;
            ViewBag.str = "hello";
            return View();
        }

        [HttpGet]
        public IActionResult Action1()
        {
            return View(new Model1());
        }
        [HttpPost]
        public IActionResult Action1(Model1 obj)
        {
            if (ModelState.IsValid)
            {
                return View("disp", obj);
            }
            return NotFound();
        }


    }
}
