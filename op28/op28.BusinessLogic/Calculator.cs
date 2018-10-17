using System;
using System.Collections.Generic;
using System.Text;

namespace op28.BusinessLogic {
    public class Calculator : App {
        public Calculator() : this("Calculator"){

        }

        public Calculator(string name) : base(name) {

        }
        public override void Install() {
            Console.WriteLine("Installing calculator...");
        }

        public override void Start() {
            Console.WriteLine("Starting Calculator...");
        }

        public double Add(double a, double b) {
            return a + b;
        }
        public double Subtract(double a, double b) {
            return a - b;
        }
        public double Multiply(double a, double b) {
            return a * b;
        }
        public double Divide(double a, double b) {
            if (b == 0)
                throw new ArgumentException("divisor cannot be  0!"); 
            return a / b;
        }
        

        
    }
}
