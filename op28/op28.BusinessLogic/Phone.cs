using System;
using System.Collections.Generic;
using System.Text;

namespace op28.BusinessLogic {
    public class Phone {
        public string Brand { get; set; }
        public string Model { get; set; }
        public AppDrawer AppDrawer { get; private set; }
        public Phone() {
            AppDrawer = new AppDrawer();
        }
    }
}
