using System;
using System.Collections.Generic;
using System.Text;

namespace op22.ConsoleApplication {
    public struct Digit {
        public int Value { get; set; }
        public Digit(int value) {
            if (value>=0 && value<=9) {
                Value = value;
            }
            Value = 0;
        }
        public void Add(Digit d) {

        }
    }
}
