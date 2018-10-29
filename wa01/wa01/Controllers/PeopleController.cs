using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wa01.Models;

namespace wa01.Controllers{
    public class PeopleController : Controller {
        private PeopleListRepository repo = new PeopleListRepository();
        public IActionResult Index() {
            return View(repo.GetAll());
        }
        public IActionResult Details(int id) {
            Person person = repo.GetPersonById(id);
            if (person == null) {
                return NotFound();
            }
            return View(person);
        }
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person) {
            if (ModelState.IsValid) {
                repo.Insert(person);
                return RedirectToAction(nameof(Index));
            } else {
                return View();
            }
        }
    }
}