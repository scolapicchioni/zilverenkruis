using System;
using System.Collections.Generic;
using System.Text;

namespace op29.BusinessLogic {
    public class CollectionExamples {
        public void ListExample() {
            List<Potato> potatoes = new List<Potato>() {
                new Potato() {
                    Color = "Blue",
                    Shape = "Square",
                    Size = 200,
                    SnelKokend = false
                },
                new Potato() { Color = "Blue", Shape = "Square", Size = 30, SnelKokend = false },
                new Potato() { Color = "Red", Shape = "Square", Size = 100, SnelKokend = false },
                new Potato() { Color = "Yellow", Shape = "Square", Size = 10, SnelKokend = false }
            };
            potatoes.Add(new Potato() { Color = "Orange", Shape = "Square", Size = 50, SnelKokend = false });
            Potato p = new Potato() {
                Color = "Multicolor",
                Shape = "Square",
                Size = 2,
                SnelKokend = false
            };
            potatoes.Add(p);

            p.Size = 1;


            potatoes.Remove(p);
            potatoes.RemoveAt(0);

            potatoes.AddRange(new Potato[] { new Potato(), new Potato(), new Potato() });

            bool b = potatoes.Contains(p);

            List<Potato> blues = potatoes.FindAll(par => par.Color=="Blue");
            potatoes.ForEach(item => Console.WriteLine(item));
            //potatoes.ForEach(DoSomething);

            Console.WriteLine("*******************");
            potatoes.Sort();
            potatoes.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("*******************");

            Potato third = potatoes[3];
            foreach (Potato item in potatoes) {

            }

            //List<int> numbers = new List<int>() {
            //    1,5,2,8,5,9,5,2,6,8,0,43,7,3
            //};

            //numbers.Sort();

            //numbers.ForEach(n => Console.WriteLine(n));

            Dictionary<string, Potato> dictionary = new Dictionary<string, Potato>();
            dictionary["mario"] = p;
            Potato potato = dictionary["mario"];

            dictionary.Add("peach", new Potato());
            foreach (string key in dictionary.Keys) {
                Console.WriteLine($"{key} {dictionary[key]}"); 
            }
            

        }

        private void DoSomething(Potato p) {
            Console.WriteLine(p);
        }
    }
}
