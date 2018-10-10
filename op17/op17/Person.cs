using System;
using System.Collections.Generic;
using System.Text;

namespace op17 {
    public class Person { 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        //public Person() {
        //    Console.WriteLine("DEFAULT Constructor of a new Person");
        //}

        public Person(string name, string surname) {
            Console.WriteLine("Constructor with 2 params of a new Person");
            Name = name;
            Surname = surname;
        }

        public virtual string SayHi() {
            return $"Hi, my name is {Name} {Surname}";
        }

        public override string ToString() {
            return $"{Name} {Surname}";
        }
    }
}
