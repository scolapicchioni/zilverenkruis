using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataHelper;

namespace op29.BusinessLogic {
    public class LinqExamples {
        public void Linq01() {
            List<Car> cars = new List<Car>() {
                new Car(){Brand="FIAT", Color="Red", Model="500", Price=10000 },
                new Car(){Brand="FIAT", Color="Blue", Model="Punto", Price=15000 },
                new Car(){Brand="FIAT", Color="Green", Model="Panda", Price=9000 },
                new Car(){Brand="Ferrari", Color="Red", Model="Enzo", Price=100000 },
                new Car(){Brand="Ferrari", Color="Red", Model="Testarossa", Price=120000 },
                new Car(){Brand="Lamborghini", Color="Yellow", Model="Countach", Price=200000 }
            };

            bool arethereoverpricedcars = cars.Any(c => c.Price > 150000);
            Console.WriteLine(arethereoverpricedcars);

            IEnumerable<Car> query =
                cars
                .Where(c => {
                    Console.WriteLine($"THIS IS THE WHERE METHOD COMPARING {c}");
                    return c.Model.StartsWith("P");
                }).OrderBy(c => {
                    Console.WriteLine($"\tTHIS IS THE ORDERBY METHOD ORDERING {c}");
                    return c.Color;
                });

            cars.Add(new Car() { Brand = "VERY", Model = "EXPENSIVE", Price = 999999999, Color = "BLACK" });

            foreach (Car item in query) {
                Console.WriteLine($"\t\tFOREACH: {item}");
            }
        
        }

        public void Linq02() {
            IEnumerable<Employee> employees = DataSource.Employees;

            IEnumerable<Employee> query = employees.Where(e => {
                Console.WriteLine($"WHERE SICKLEAVE {e.SickLeaveHours}");
                return e.SickLeaveHours > 21;
            });
            
            IEnumerable<Employee> q2 = query.Where(e=> {
                Console.WriteLine($"\tWHERE GENDER {e.Gender}");
                return e.Gender == 'M';
            });

            foreach (Employee item in q2) {
                Console.WriteLine($"\t\tforeach: {item.Name} {item.SickLeaveHours} {item.Gender}");
            }

        }
        public void Linq03() {
            IEnumerable<Employee> employees = DataSource.Employees;

            IEnumerable<string> names = employees.Select(e => e.Name);

            var query = employees
                .Where(e => e.SickLeaveHours < 50)
                .OrderBy(e=>e.Name)
                .Select(e => new { e.Name, e.Gender });

            foreach (var item in query) {
                Console.WriteLine(item);
            }

            var query2 = from e in employees
                         where e.SickLeaveHours < 50
                         orderby e.Name
                         select new { e.Name, e.Gender };


        }
    }
}
