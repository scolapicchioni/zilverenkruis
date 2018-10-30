using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample.ConsoleApplication.Tests {
    public class LoserDice : IDice {
        public int Roll() {
            return 1;
        }
    }
}
