using op26.BusinessLogic;
using System;

namespace op26.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Phone oldPhone = new Phone() { Brand="Samsung", Model="S5"};
            oldPhone.Contacts.AddRange(new[] {
                new Contact() { Name="Mario", Surname="Super", PhoneNumber="06123123"},
                new Contact() { Name="Luigi", Surname="Super", PhoneNumber="06123124"},
                new Contact() { Name="Princess", Surname="Peach", PhoneNumber="06765765"}
            });

            Phone newPhoneWhoDis = new Phone() { Brand = "WhoDis", Model = "NewPhone" };
            TechSupport yeOldeTechSupport = new TechSupport();
            yeOldeTechSupport.CopyContacts(oldPhone, newPhoneWhoDis);

            foreach (Contact item in newPhoneWhoDis.Contacts) {
                Console.WriteLine($"{item.Name} {item.Surname} {item.PhoneNumber}");
            }

            Console.ReadLine();
        }
    }
}
