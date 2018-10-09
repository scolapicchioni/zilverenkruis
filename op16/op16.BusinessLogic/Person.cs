using System;
using System.Collections.Generic;
using System.Text;

namespace op16.BusinessLogic {
    public class Person {
        public Person(string name, Course course) {
            Name = name;
            CurrentCourse = course;
        }

        public string Name { get; set; }
        public Course CurrentCourse { get; set; }
    }
}
