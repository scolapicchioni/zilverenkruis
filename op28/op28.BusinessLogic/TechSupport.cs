using System;
using System.Collections.Generic;
using System.Text;

namespace op28.BusinessLogic {
    public class TechSupport {
        public void CopyContacts(Phone source, Phone target) {
            ContactsApp sourceContacts = source.AppDrawer.Find<ContactsApp>();
            ContactsApp targetContacts = target.AppDrawer.Find<ContactsApp>();

            foreach (Contact item in sourceContacts.Contacts) {
                targetContacts.Add(item.Name, item.Surname, item.PhoneNumber);
            }
        }
    }
}
