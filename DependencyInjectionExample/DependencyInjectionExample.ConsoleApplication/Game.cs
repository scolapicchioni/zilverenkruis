using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample.ConsoleApplication {
    public class Game {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Player Start() {
            int rp1 = Player1.Play();
            int rp2 = Player2.Play();

            if (rp1 > rp2) {
                return Player1;
            } else if (rp2 > rp1) {
                return Player2;
            } else {
                return null;
            }
        }
    }
}
