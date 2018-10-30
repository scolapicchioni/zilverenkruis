using System;

namespace DependencyInjectionExample.ConsoleApplication {
    public class Player {
        IDice dice;
        public Player(IDice _dice) {
            dice = _dice;
        }
        public int Play() {
            return dice.Roll();    
        }
    }
}