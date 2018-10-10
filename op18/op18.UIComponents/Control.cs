using System;
using System.Collections.Generic;
using System.Text;

namespace op18.UIComponents {
    public class Control {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleColor ForegroundColor { get; set; }

        public Control() {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            Top = 0;
            Left = 0;
            Height = 1;
            Width = 10;
            Text = "";
        }
        public virtual void Draw() {
            Console.SetCursorPosition(Left, Top);
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = ForegroundColor;
            Console.WriteLine(Text);
        }
    }
}
