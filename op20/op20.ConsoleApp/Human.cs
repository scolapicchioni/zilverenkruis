using System;
using System.Collections.Generic;
using System.Text;

namespace op20.ConsoleApp {
    public class Human :IPlayer{
        public string Name { get; set; }
        public int Score { get; set; }
        public Choice LastChoice { get; set; }
        public Human() {
            Name = "Human";
        }
        public void Play() {
            bool ok = false;
            do {
                Console.WriteLine($"{Name}, please select 1 for Rock, 2 for Paper, 3 for Scissors");
                try {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= 3) {
                        ok = true;
                        LastChoice = (Choice)(choice - 1);
                    }
                } catch {
                }
            } while (!ok);
        }
    }
}
