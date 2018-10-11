using System;
using System.Collections.Generic;
using System.Text;

namespace op19.ConsoleApp {
    public class Computer {
        public void Plug(USB device) {
            device.Power();
            string result = device.Start();
        }
    }
}
