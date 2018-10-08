using System;
using System.Collections.Generic;
using System.Text;

namespace op15.ConsoleApplication {
    public class Person {
        private string surname;

        public string Surname {
            get { return surname; }
            set {
                if (value.Length > 50)
                    value = value.Substring(0, 50);
                surname = value;
            }
        }
    }
}
