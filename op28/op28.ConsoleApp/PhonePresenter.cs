using op28.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace op28.ConsoleApp {
    public class PhonePresenter {
        public PhonePresenter(Phone phone) {
            Phone = phone;
            presenters = new List<IAppPresenter>();
            foreach (var item in phone.AppDrawer.Apps) {
                switch (item) {
                    case Calculator c:
                        presenters.Add(new CalculatorPresenter(phone));
                        break;
                    case ContactsApp c:
                        presenters.Add(new ContactsAppPresenter(phone));
                        break;
                }
            }
        }

        public Phone Phone { get; }

        List<IAppPresenter> presenters;

        public void Start() {
            string input;
            do {
                Console.Clear();
                for (int i = 0; i < presenters.Count; i++) {
                    Console.WriteLine($"{i+1}. {presenters[i].Name}");
                }
                Console.WriteLine("X. Exit");
                input = Console.ReadLine();
                try {
                    int n = int.Parse(input);
                    presenters[n - 1].Start();
                } catch {

                }
            } while (input.ToLower() != "x");
        }
    }
}
