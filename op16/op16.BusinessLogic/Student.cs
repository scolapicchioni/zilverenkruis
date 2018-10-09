using System;
using System.Collections.Generic;
using System.Text;

namespace op16.BusinessLogic {
    public class Student : Person{
        public Student(int studentId, string name, Course course) 
            : base(name, course) {
            StudentId = studentId;
        }
        public int StudentId { get; set; }
    }
}
