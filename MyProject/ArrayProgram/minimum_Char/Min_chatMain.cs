using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.minimum_Char
{
    class Min_chatMain
    {
        static void Main(string[] args)
        {
            MINChar m = new MINChar();
            Console.WriteLine("enter size");
            int size = int.Parse(Console.ReadLine());
            char[] ch = new char[size];
            Console.WriteLine("enter value");
            for(int i=0;i<ch.Length;i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            char f;
            f = m.Display_min_char(ch);
            Console.WriteLine("min char index = "+(int)(f)+" and veriable is = "+f);
          

        }
    }
}
