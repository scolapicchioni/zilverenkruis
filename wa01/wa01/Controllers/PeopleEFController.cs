using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using wa01.Models;

namespace wa01.Controllers
{
    public class PeopleEFController : Controller
    {
        private readonly IPeopleRepository _repo;

        public PeopleEFController(IPeopleRepository context)
        {
            _repo = context;
        }

        // GET: PeopleEF
        public async Task<IActionResult> Index()
        {
            return View(await _repo.GetAll());
        }

        // GET: PeopleEF/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _repo.GetPersonById(id.Value);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: PeopleEF/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PeopleEF/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Age")] Person person)
        {
            if (ModelState.IsValid)
            {
                await _repo.Create(person);
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // GET: PeopleEF/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _repo.GetPersonById(id.Value);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        // POST: PeopleEF/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Age")] Person person)
        {
            if (id != person.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try {
                    await _repo.Update(person);
                } catch (NotFoundException) {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // GET: PeopleEF/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _repo.GetPersonById(id.Value);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: PeopleEF/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id) {
            return _repo.PersonExists(id);
        }
    }
}
