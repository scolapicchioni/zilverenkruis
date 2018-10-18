using System;
using System.Collections.Generic;
using System.Text;

namespace op29.BusinessLogic {
    public class Car {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public override string ToString() {
            return $"{Brand} {Model} {Color} {Price}";
        }
    }
}
