using System;
using System.Collections.Generic;
using System.Text;

namespace op18.UIComponents {
    public class Form {
        public Control[] Controls { get; set; }
        public Form() {
            Controls = new Control[50];
        }
        public void Draw() {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < Controls.Length; i++) {
                if (Controls[i] != null)
                    Controls[i].Draw();
            }
        }
    }
}
