using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wa01.Models;

namespace wa01.Controllers
{
    public class SimoController : Controller
    {
        public string SayHi() {
            return "<html><head></head><body><h1>Hello World!</h1></body></html>";
        }

        public ViewResult SayHiWithView() {
            return View();
        }

        public ViewResult GetPerson() {
            Person person = new Person() {Id=1, Name = "Simona", Surname="Colapicchioni", Age=44 }; 
            return View(person);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}