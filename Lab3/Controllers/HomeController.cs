using Microsoft.AspNetCore.Mvc;
using Lab3.Models;
using System;
using System.Reflection;

namespace Lab3.Controllers
{
    public class HomeController : Controller
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

            if (Request.Form["numBottles"] == "")
            {
                return View("SongForm");
            }

            else
            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            
            if (person.FirstName == null || person.LastName == null || person.EmailAddresss == null || person.Password == null || person.Desc == null || Request.Form["age"] == "")
            {
                return View("Error");
            }   
            
            else

            return View(person);
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
