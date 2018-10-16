using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace op27.BusinessLogic.Tests {
    public class CalculatorTests {
        [Fact]
        public void GivenANewCalculator_WhenDividingByZero_ThenDivideShouldThrow() {
            //GivenANewCalculator
            Calculator calc = new Calculator();
            //WhenDividingByZero
            //ThenDivideShouldThrow
            Assert.Throws<ArgumentException>(() => calc.Divide(1, 0));
        }
    }
}
