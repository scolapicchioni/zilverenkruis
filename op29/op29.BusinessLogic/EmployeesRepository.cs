using DataHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace op29.BusinessLogic {
    public class EmployeesRepository {
        public int HowManyEmployees() {
            return DataSource.Employees.Count();
        }
        public int HowManyFemaleEmployees() {
            return DataSource.Employees.Count(e => e.Gender == 'F');
        }

        public int HowManySickLeaveHours() {
            return DataSource.Employees.Sum(e => e.SickLeaveHours);
        }

        public double AverageSickLeaveHours() {
            return DataSource.Employees.Average(e => e.SickLeaveHours);
        }

        public int MaxSickLeaveHours() {
            return DataSource.Employees.Max(e => e.SickLeaveHours);
        }

        public int MinSickLeaveHours() {
            return DataSource.Employees.Min(e => e.SickLeaveHours);
        }

        public Employee FirstFemale() {
            return DataSource.Employees.First(e => e.Gender == 'F');
        }

        public Employee Youngest() {
            return DataSource.Employees.First(e => e.BirthDate == DataSource.Employees.Max(em=>em.BirthDate));
        }

        public Employee FirstWhoseBirthYearIs(int year) {
            return DataSource.Employees.First(e => e.BirthDate.Year == 1974);
        }

        public Employee FirstWhoseBirthYearIsOrNull(int year) {
            return DataSource.Employees.FirstOrDefault(e => e.BirthDate.Year == 1974);
        }

        public Employee LastWhoseBirthYearIs(int year) {
            return DataSource.Employees.Last(e => e.BirthDate.Year == 1974);
        }

        public Employee LastWhoseBirthYearIsOrNull(int year) {
            return DataSource.Employees.LastOrDefault(e => e.BirthDate.Year == 1974);
        }

        public Employee Oldest() {
            return DataSource.Employees.Last(e => e.BirthDate == DataSource.Employees.Min(em => em.BirthDate));
        }

        public Employee OnlyOneWhoseBirthYearIs(int year) {
            return DataSource.Employees.Single(e => e.BirthDate.Year == 1974);
        }

        public Employee OnlyOneWhoseBirthYearIsOrNull(int year) {
            return DataSource.Employees.SingleOrDefault(e => e.BirthDate.Year == 1974);
        }

        public Employee ElementAt(int index) {
            return DataSource.Employees.ElementAt(index);
        }

        public Employee ElementAtOrNull(int index) {
            return DataSource.Employees.ElementAtOrDefault(index);
        }

        public IEnumerable<Employee> FromOldestToYoungest() {
            return DataSource.Employees.OrderBy(e => e.BirthDate);
        }

        public IEnumerable<Employee> FromYoungestToOldest() {
            return DataSource.Employees.OrderByDescending(e => e.BirthDate);
        }

        public IEnumerable<Employee> OrderByGenderBirthDate() {
            return DataSource.Employees.OrderBy(e=>e.Gender).ThenByDescending(e => e.BirthDate);
        }

        public IEnumerable<Employee> Females() {
            return DataSource.Employees.Where(e => e.Gender == 'F');
        }

        public IEnumerable<dynamic> Bla() {
            return DataSource.Employees.Select(e => new { Name = e.Name.Split()[0], Surname = e.Name.Split()[1], e.BirthDate });
        }

        public void Blah() {

            var list = DataSource.Employees
                .Where(e => e.SickLeaveHours < 50)
                .OrderBy(e => e.Gender)
                .ThenBy(e => e.Name)
                .Select(e => new { e.Name, e.SickLeaveHours });
            foreach (var item in list) {
                
            }

            var query = from e in DataSource.Employees
                        select e;


            query = from e in DataSource.Employees
                    where e.Name.StartsWith("A")
                    orderby e.Gender descending, e.Name ascending
                    select e;

            foreach (Employee item in query) {

            }

            var q2 = from e in DataSource.Employees
                     select new { e.SickLeaveHours };

            foreach (var item in q2) {
                
            }

            var q3 = from e in DataSource.Employees
                     group e by e.Gender;

            foreach (var group in q3) {
                Console.WriteLine(group.Key);
                foreach (var item in group) {
                    Console.WriteLine(item.Name);
                }
            }

            var q4 = from e in DataSource.Employees
                     group new { FullName = e.Name, e.BirthDate.Year }
                     by new { e.Gender, InitialLetter = e.Name.Substring(0,1) };

            foreach (var group in q4) {
                Console.WriteLine($"{group.Key.Gender} {group.Key.InitialLetter}");
                foreach (var item in group) {
                    Console.WriteLine($"\t{item.FullName} {item.Year}");
                }
            }

            var q5 = from prod in DataSource.Products
                     join price in DataSource.ProductVendors
                     on prod.ID equals price.ProductID
                     select new { prod.Name, price.Price };


            var q6 = from prod in DataSource.Products
                     join price in DataSource.ProductVendors
                     on prod.ID equals price.ProductID
                     join vendor in DataSource.Vendors
                     on price.VendorID equals vendor.ID
                     select new { ProductName = prod.Name, price.Price , VendorName = vendor.Name};
        }
    }
}
