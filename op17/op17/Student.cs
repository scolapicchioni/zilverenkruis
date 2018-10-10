using System;
using System.Collections.Generic;
using System.Text;

namespace op17 {
    public class Student : Person {
        
        public int StudentId { get; set; }

        public void Study() {
            Console.WriteLine("Student studying....");
        }

        public override string SayHi() { //polymorphic method
            return $"Hi, my name is {Name} {Surname} and my StudentId is {StudentId}";
        }

        public Student() : base("",""){
            Console.WriteLine("DEFAULT Constructor of a new Student");
        }

        public Student(string surname, string address) : base("", surname) {
            Console.WriteLine("Constructor with 2 params of a new Student");
            Address = address;
        }
    }
}
