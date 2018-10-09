using System;
using System.Collections.Generic;
using System.Text;

namespace op16.BusinessLogic {
    public class Teacher : Person {
        public Teacher(string name, Course course, decimal salary) 
            : base(name, course) {
            Salary = salary;
        }
        public decimal Salary { get; set; }
    }
}
