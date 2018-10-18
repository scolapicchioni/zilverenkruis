using op28.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace op28.ConsoleApp {
    public class PhonePresenter {
        public PhonePresenter(Phone phone) {
            Phone = phone;
            Presenters = new List<IAppPresenter>();
        }

        public Phone Phone { get; }

        public List<IAppPresenter> Presenters { get; }

        public void Start() {
            string input;
            do {
                Console.Clear();
                for (int i = 0; i < Presenters.Count; i++) {
                    Console.WriteLine($"{i+1}. {Presenters[i].Name}");
                }
                Console.WriteLine("X. Exit");
                input = Console.ReadLine();
                try {
                    int n = int.Parse(input);
                    Presenters[n - 1].Start();
                } catch {

                }
            } while (input.ToLower() != "x");
        }
    }
}
