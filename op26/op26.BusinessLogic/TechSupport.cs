using System;
using System.Collections.Generic;
using System.Text;

namespace op26.BusinessLogic {
    public class TechSupport {
        public void CopyContacts(Phone source, Phone target) {
            foreach (Contact item in source.Contacts) {
                target.Contacts.Add(item.Name, item.Surname, item.PhoneNumber);
                //target.Contacts.Add(item);
            }
        }
    }
}
