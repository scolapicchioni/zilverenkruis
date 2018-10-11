using System;
using System.Collections.Generic;
using System.Text;

namespace op20.ConsoleApp {
    public class Computer : IPlayer {
        public string Name { get; set; }
        public int Score { get; set; }
        public Choice LastChoice { get; set; }
        private Random generator = new Random();
        public Computer() {
            Name = "Computer";
        }
        public void Play() {
            LastChoice = (Choice)generator.Next(0,3);
        }
    }
}
