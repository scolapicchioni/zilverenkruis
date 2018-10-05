using System;
using System.Collections.Generic;
using System.Text;

namespace op14 {
    public class Person {
        public string Name;
        private string surname;
        public string Address;

        //p1.SetSurname("123456789012345678901234567890123456789012345678901234567890");
        public void SetSurname(string surname) 
        {
            if (surname.Length > 50) {
                surname = surname.Substring(0, 50);
            }
            this.surname = surname;
        }

        public string GetSurname() {
            return surname;
        }

        public string Surname 
        {
            get 
            {
                return surname;
            }
            set 
            {
                if (value.Length > 50) {
                    value = value.Substring(0, 50);
                }
                surname = value;
            }
        }

    }
}
