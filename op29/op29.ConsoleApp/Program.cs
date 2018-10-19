using DataHelper;
using op29.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace op29.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Repository repo = new Repository();
            repo.WriteOnFile("Hello World!\r\n");

            Potato potato = new Potato() {
                Color = "Red",
                Shape = "Long",
                SnelKokend = true,
                Size = 3
            };
            //repo.SerializeBinary(potato);

            //Potato potato2 = repo.DeserializeBinary();

            //repo.SerializeXML(potato);
            //Potato potato2 = repo.DeserializeXML();

            //repo.SerializeJSON(potato);
            //Potato potato2 = repo.DeserializeJSON();

            //CollectionExamples ce = new CollectionExamples();

            //ce.ListExample();

            //LinqExamples le = new LinqExamples();
            //le.Linq02();

            EmployeesRepository employees = new EmployeesRepository();
            Console.WriteLine($"We have {employees.HowManyEmployees()} employees");
            Console.WriteLine($"We have {employees.HowManyFemaleEmployees()} female employees");
            Console.WriteLine($"We have a total of {employees.HowManySickLeaveHours()} sick leave hours");
            Console.WriteLine($"The average sick leave hours of our employees is {employees.AverageSickLeaveHours()}");
            Console.WriteLine($"The maximum sick leave hours of our employees is {employees.MaxSickLeaveHours()}");
            Console.WriteLine($"The minimum sick leave hours of our employees is {employees.MinSickLeaveHours()}");

            Console.WriteLine($"Our First Female is: {employees.FirstFemale()}");
            Console.WriteLine($"First born in 1974: {employees.FirstWhoseBirthYearIs(1974)}");
            Console.WriteLine($"Youngest: {employees.Youngest()}");

            printEmployees(employees.FromOldestToYoungest(), "FROM OLDEST TO YOUNGEST");

            printEmployees(employees.FromYoungestToOldest(), "FROM YOUNGEST TO OLDEST");
            printEmployees(employees.OrderByGenderBirthDate(), "GENDER, THEN BIRTHDATE");
            string s = "abcdefghtypmd";
            s.Count(l => l == 'a');

            int[] list = new int[] { 1, 4, 7, 3, 2, 6, 8, 7, 4, 33, 76, 9, 6 };
            list.Min();
            list.Min(n => n % 2 == 1);

            foreach (var item in employees.Bla()) {
                Console.WriteLine(item.Name); 
            } 

            Console.WriteLine("Done...");
            Console.ReadLine();
        }

        private static void printEmployees(IEnumerable<Employee> employees, string message) {
            Console.WriteLine($"*******{message}*********");
            foreach (Employee employee in employees) {
                Console.WriteLine(employee);
            }
        }
    }
}
