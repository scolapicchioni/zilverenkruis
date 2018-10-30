using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace wa01.Models {
    public class PeopleEFRepository : IPeopleRepository {
        private readonly ApplicationContext _context;

        public PeopleEFRepository(ApplicationContext context) {
            _context = context;
        }

        public async Task<List<Person>> GetAll() {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person> GetPersonById(int id) {
            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.Id == id);
            return person;
        }

        public async Task Create(Person person) {
            _context.Add(person);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Person person) {
            try {
                _context.Update(person);
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!PersonExists(person.Id)) {
                    throw new NotFoundException();
                } else {
                    throw new UpdateException();
                }
            }
        }

        public async Task Delete(int id) {
            var person = await _context.Person.FindAsync(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
        }

        public bool PersonExists(int id) {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
