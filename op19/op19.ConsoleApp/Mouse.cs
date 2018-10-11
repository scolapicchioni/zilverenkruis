using System;
using System.Collections.Generic;
using System.Text;

namespace op19.ConsoleApp {
    public class Mouse : USB{
        public void Power() {
            Console.WriteLine("Mouse has THE power now... muhahaha");
        }
        public string Start() {
            return "Mouse started...";
        }
    }
}
