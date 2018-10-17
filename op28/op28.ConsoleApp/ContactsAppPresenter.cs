using op28.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace op28.ConsoleApp {
    public class ContactsAppPresenter : IAppPresenter{
        public ContactsAppPresenter(Phone phone) {
            Phone = phone;
            ContactsApp = Phone.AppDrawer.Find<ContactsApp>();
            Name = ContactsApp.Name;
        }
        public string Name { get; set; }
        public Phone Phone { get; }
        ContactsApp ContactsApp { get; }

        private int askNumber(string message) {
            int number=0;
            bool ok = false;
            do {
                Console.Write(message);
                try {
                    number = int.Parse(Console.ReadLine());
                    ok = true;
                } catch {
                }
            } while (!ok);
            return number;
        }

        public void Start() {
            string input; 
            do {
                Console.Clear();
                Console.WriteLine("1. List All Contacts");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Search By Surname");
                Console.WriteLine("4. Search By Name");
                Console.WriteLine("5. Search By Phone Number");
                Console.WriteLine("X. Exit");
                input = Console.ReadLine();
                switch (input) {
                    case "1":
                        ShowContacts(ContactsApp.Contacts);
                        break;
                    case "2":
                        AddContact();
                        break;
                    case "3":
                        SearchBySurname();
                        break;
                    case "4":
                        SearchByName();
                        break;
                    case "5":
                        SearchByPhoneNumber();
                        break;
                }
            } while (input.ToLower() != "x");
            
        }

        private void ShowContacts(List<Contact> contacts) {
            Console.Clear();
            foreach (Contact item in contacts) {
                Console.WriteLine($"{item.Name}\t{item.Surname}\t{item.PhoneNumber}");
            }
            Console.ReadLine();
        }

        private void AddContact() {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            ContactsApp.Add(name, surname,phoneNumber);
            Console.ReadLine();
        }

        private void SearchBySurname() {
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Result: ");
            ShowContacts(ContactsApp.Filter(c => c.Surname.ToLower().Contains(surname)));
        }

        private void SearchByName() {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Result: ");
            ShowContacts(ContactsApp.Filter(c => c.Name.ToLower().Contains(name)));
        }

        private void SearchByPhoneNumber() {
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Result: ");
            ShowContacts(ContactsApp.Filter(c => c.PhoneNumber.ToLower().Contains(phoneNumber)));
        }

    }
}
