using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Swap
    {
        static void Main(string[] args)
        {
            int a = 40; 
            int b = 50;
            a = a + b;      // a=90
            b = a - b;      // b= 90-50=40
            a = a - b;      // a =90-40 =50

            Console.WriteLine( " a :==> "+a + "    b :==> "+b);
        }
        

    }
}
