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
                int[] values = (int[])Enum.GetValues(typeof(Choice));
                string[] names = Enum.GetNames(typeof(Choice));
                string message = "Please select:\n";
                for (int i = 0; i < values.Length; i++) {
                    message += $"\t{values[i]} for {names[i]}\n";
                }
                Console.WriteLine($"{Name}, {message}");
                try {
                    int choice = int.Parse(Console.ReadLine());
                    if(Enum.IsDefined(typeof(Choice), choice)) { 
                        ok = true;
                        LastChoice = (Choice)choice;
                    }
                } catch {
                }
            } while (!ok);
        }
    }
}
