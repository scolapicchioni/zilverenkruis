using System;

namespace op19.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Computer dell = new Computer();
            
            Mouse m = new Mouse();

            dell.Plug(m);
            //stuff = new USB();
        }
    }
}
