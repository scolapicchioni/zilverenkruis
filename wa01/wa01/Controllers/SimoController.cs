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

        public ViewResult GetPerson(int id) {
            List<Person> people = new List<Person>(){
                new Person() { Id = 1, Name = "Simona", Surname = "Colapicchioni", Age = 44 },
                new Person() { Id = 2, Name = "Mario", Surname = "Super", Age = 50 },
                new Person() { Id = 3, Name = "Luigi", Surname = "Super", Age = 48 },
                new Person() { Id = 4, Name = "Princess", Surname = "Peach", Age = 25 }
            };

            Person person = people.FirstOrDefault(p=> p.Id == id);
            return View(person);
        }

        public ViewResult GetPeople() {
            List<Person> people = new List<Person>(){
                new Person() { Id = 1, Name = "Simona", Surname = "Colapicchioni", Age = 44 },
                new Person() { Id = 2, Name = "Mario", Surname = "Super", Age = 50 },
                new Person() { Id = 3, Name = "Luigi", Surname = "Super", Age = 48 },
                new Person() { Id = 4, Name = "Princess", Surname = "Peach", Age = 25 }
            };
            return View(people);
        }

        //simo/CreatePerson
        public ViewResult CreatePerson() {
            return View();
        }

        [HttpPost] //constraint
        public IActionResult CreatePerson(Person person) {
            if (ModelState.IsValid) {
                //insert person in db
                return RedirectToAction("GetPeople");
            } else {
                return View();
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}