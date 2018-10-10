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
            Label l1 = new Label();
            l1.Top = 10;
            l1.Left = 3;
            
            l1.BackgroundColor = ConsoleColor.DarkGray;
            l1.ForegroundColor = ConsoleColor.Yellow;
            l1.Text = "What is your name?";
            l1.Width = l1.Text.Length;
            mainForm.Controls[0] = l1;

            TextBox t1 = new TextBox();
            t1.Top = 10;
            t1.Left = 25;
            t1.BackgroundColor = ConsoleColor.DarkBlue;
            t1.ForegroundColor = ConsoleColor.DarkYellow;
            t1.Text = "";
            mainForm.Controls[1] = t1;

            Label l2 = new Label();
            l2.Top = 15;
            l2.Left = 3;
            l2.BackgroundColor = ConsoleColor.DarkGray;
            l2.ForegroundColor = ConsoleColor.Yellow;
            mainForm.Controls[2] = l2;

            mainForm.Draw();

            l2.Text = $"Hello {t1.Input()}!";
            l2.Width = l2.Text.Length;

            mainForm.Draw();

            Console.ReadLine();
        }
    }
}
