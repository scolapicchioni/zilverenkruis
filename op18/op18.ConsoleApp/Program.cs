using op18.UIComponents;
using System;

namespace op18.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            //
            /*
             * 
             *  --------------------  =========================
             *  | What's Your Name? | || Simona              ||
             *  --------------------- =========================
             *
             *  ---------------------
             *  | Hello Simona!     |
             *  ---------------------
             */

            Form mainForm = new Form();
            Control c1 = new Control();
            c1.Top = 0;
            c1.Left = 10;
            c1.BackgroundColor = ConsoleColor.Red;
            c1.ForegroundColor = ConsoleColor.Blue;
            c1.Text = "Control 1";
            mainForm.Controls[0] = c1;

            Control c2 = new Control();
            c2.Top = 5;
            c2.Left = 10;
            c2.BackgroundColor = ConsoleColor.Yellow;
            c2.ForegroundColor = ConsoleColor.Magenta;
            c2.Text = "Control 2";
            mainForm.Controls[1] = c2;

            Label l1 = new Label();
            l1.Top = 15;
            l1.Left = 10;
            l1.BackgroundColor = ConsoleColor.Gray;
            l1.ForegroundColor = ConsoleColor.Cyan;
            l1.Text = "Label 1";
            mainForm.Controls[2] = l1;

            TextBox t1 = new TextBox();
            t1.Top = 25;
            t1.Left = 10;
            t1.BackgroundColor = ConsoleColor.DarkBlue;
            t1.ForegroundColor = ConsoleColor.DarkYellow;
            t1.Text = "TextBox 1";
            mainForm.Controls[3] = t1;

            mainForm.Draw();

            Console.ReadLine();
        }
    }
}
