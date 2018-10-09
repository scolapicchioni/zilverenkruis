using System;
using System.Collections.Generic;
using System.Text;

namespace op16.BusinessLogic {
    public class School {
        public Teacher[] Teachers { get; set; }
        public Course[] Courses { get; set; }
        public Student[] Students { get; set; }

        public Course CreateCourse(string name) {
            //look for the course
            //if found
            //  return found
            //if not found
            //  create course
            //  save it in the list
            //  return newly created course
        }
    }
}
