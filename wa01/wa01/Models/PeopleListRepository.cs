using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa01.Models {
    public class PeopleListRepository {
        private static List<Person> db = new List<Person>(){
            new Person() { Id = 1, Name = "Simona", Surname = "Colapicchioni", Age = 44 },
            new Person() { Id = 2, Name = "Mario", Surname = "Super", Age = 50 },
            new Person() { Id = 3, Name = "Luigi", Surname = "Super", Age = 48 },
            new Person() { Id = 4, Name = "Princess", Surname = "Peach", Age = 25 }
        };

        public List<Person> GetAll() {
            return db;
        }

        public Person GetPersonById(int id) {
            return db.FirstOrDefault(p => p.Id == id);
        }

        public void Insert(Person toInsert) {
            toInsert.Id = db.Count==0 ? 1 : db.Max(p => p.Id) + 1;

            if (db.Count == 0) {
                toInsert.Id = 1;
            } else {
                toInsert.Id = db.Max(p => p.Id) + 1;
            }

            db.Add(toInsert);
        }

        public void Update(Person toUpdate) {
            Person old = db.First(p => p.Id == toUpdate.Id);
            old.Name = toUpdate.Name;
            old.Surname = toUpdate.Surname;
            old.Age = toUpdate.Age;
        }

        public void Delete(int id) {
            Person old = db.FirstOrDefault(p => p.Id == id);
            if (old != null) {
                db.Remove(old);
            }
        }
    }
}
