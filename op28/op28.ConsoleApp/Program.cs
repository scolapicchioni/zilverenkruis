using op28.BusinessLogic;
using System;

namespace op28.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Phone p = new Phone() { Brand = "Lenovo", Model = "P2" };
            p.AppDrawer.Install(new Calculator());
            p.AppDrawer.Install(new ContactsApp());

            PhonePresenter pp = new PhonePresenter(p);
            pp.Start();
            
            Console.ReadLine();
        }
    }
}
