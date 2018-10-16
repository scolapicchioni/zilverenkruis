using System;
using System.Collections.Generic;
using System.Text;

namespace op26.BusinessLogic {
    public class Contacts : List<Contact>{
        public void Add(string name, string surname, string phoneNumber) {
            Add(new Contact() { Name = name, Surname = surname, PhoneNumber = phoneNumber });
        }
    }
}
