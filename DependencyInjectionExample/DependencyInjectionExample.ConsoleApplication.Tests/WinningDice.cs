using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample.ConsoleApplication.Tests {
    public class WinningDice : IDice {
        public int Roll() {
            return 6;
        }
    }
}
