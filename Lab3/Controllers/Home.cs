using Microsoft.AspNetCore.Mvc;
using Lab3.Models;
using System;
using System.Reflection;

namespace Lab3.Controllers
{
    public class Home : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
       public IActionResult SongForm() => View();

        [HttpGet]
        //public IActionResult SongForm()
       // {
      //      return View();
      // }

        [HttpPost]
        public IActionResult Sing()
        {
            HttpContext.Session.SetString("numBottles", Request.Form["numBottles"]);

            //HttpContext.Session.SetInt32("numBottles", Convert.ToInt32(Request.Form["numBottles"]));
            // Console.WriteLine(Request.Form["numBottles"]);
            // Console.WriteLine(HttpContext.Session.GetString("numBottles"));

            // return View(HttpContext.Session.GetString("numBottles"));

            // you will complete this
            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            return View(person);
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
