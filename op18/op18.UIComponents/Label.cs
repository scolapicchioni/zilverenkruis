using System;
using System.Collections.Generic;
using System.Text;

namespace op18.UIComponents {
    public class Label : Control{
        public override void Draw() {
            drawBorder();

            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = ForegroundColor;

            Console.SetCursorPosition(Left + 1, Top + 1);
            Console.Write(Text.PadRight(Width));
        }

        private void drawBorder() {
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = ForegroundColor;

            //top border
            Console.SetCursorPosition(Left, Top);
            for (int i = 0; i < Width + 2; i++) {
                Console.Write("─");
            }

            //left border
            for (int i = 1; i <= Height; i++) {
                Console.SetCursorPosition(Left, Top + i);
                Console.Write("|");
            }

            //right border
            for (int i = 1; i <= Height; i++) {
                Console.SetCursorPosition(Left + Width + 1, Top + i);
                Console.Write("|");
            }

            //bottom border
            Console.SetCursorPosition(Left, Top + Height + 1);
            for (int i = 0; i < Width + 2; i++) {
                Console.Write("─");
            }
        }
    }
}
