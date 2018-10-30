using System;

namespace DependencyInjectionExample.ConsoleApplication {
    public class Dice : IDice {
        private Random generator = new Random();
        public int Roll() {
            return generator.Next(1, 7);
        }
    }
}