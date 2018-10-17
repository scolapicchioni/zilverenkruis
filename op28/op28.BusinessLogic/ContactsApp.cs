using System;
using System.Collections.Generic;
using System.Text;

namespace op28.BusinessLogic {
    public class ContactsApp : App {
        public List<Contact> Contacts { get; private set; }
        public ContactsApp(): this("Contacts") {
            
        }

        public ContactsApp(string name) : base(name) {
            Contacts = new List<Contact>();
        }

        public void Add(string name, string surname, string phoneNumber) {
            Contacts.Add(new Contact() { Name = name, Surname = surname, PhoneNumber = phoneNumber });
        }

        public List<Contact> Filter(ContactChecker checker) {
            List<Contact> result = new List<Contact>();
            foreach (Contact item in Contacts) {
                if (checker(item))
                    result.Add(item);
            }
            return result;
        }

        public override void Install() {
            Console.WriteLine("Installing Contacts...");
        }

        public override void Start() {
            Console.WriteLine("Starting contacts...");
        }
    }
    public delegate bool ContactChecker(Contact contact);
}
