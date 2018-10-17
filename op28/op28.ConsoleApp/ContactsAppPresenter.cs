using op28.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace op28.ConsoleApp {
    public class ContactsAppPresenter : AppPresenter<ContactsApp>{
        public ContactsAppPresenter(Phone phone): base(phone) {
        }

        public override void Start() {
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
                        ShowContacts(App.Contacts);
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

            App.Add(name, surname,phoneNumber);
            Console.ReadLine();
        }

        private void SearchBySurname() {
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Result: ");
            ShowContacts(App.Filter(c => c.Surname.ToLower().Contains(surname)));
        }

        private void SearchByName() {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Result: ");
            ShowContacts(App.Filter(c => c.Name.ToLower().Contains(name)));
        }

        private void SearchByPhoneNumber() {
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Result: ");
            ShowContacts(App.Filter(c => c.PhoneNumber.ToLower().Contains(phoneNumber)));
        }

    }
}
