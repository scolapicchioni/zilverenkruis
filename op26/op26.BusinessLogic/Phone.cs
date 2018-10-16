using System;
using System.Collections.Generic;
using System.Text;

namespace op26.BusinessLogic {
    public class Phone {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Contacts Contacts {get; private set;}
        public Phone() {
            Contacts = new Contacts();
        }
    }
}
