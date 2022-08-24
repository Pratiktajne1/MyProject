using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Word_move
{
    class Word_Move_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Console.WriteLine("enter any number");
            int a = Convert.ToInt32(Console.ReadLine());
            Word_Move Wm = new Word_Move();
            Wm.Display(s, a);
        }
    }
}
