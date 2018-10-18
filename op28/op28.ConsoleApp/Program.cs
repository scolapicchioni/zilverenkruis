using op28.BusinessLogic;
using System;

namespace op28.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Phone phone = new Phone() { Brand = "Lenovo", Model = "P2" };
            phone.AppDrawer.Install(new Calculator());
            phone.AppDrawer.Install(new ContactsApp());

            PhonePresenter phonePresenter = new PhonePresenter(phone);
            phonePresenter.Presenters.Add(new CalculatorPresenter(phone));
            phonePresenter.Presenters.Add(new ContactsAppPresenter(phone));
            phonePresenter.Start();
            
            Console.ReadLine();
        }
    }
}
