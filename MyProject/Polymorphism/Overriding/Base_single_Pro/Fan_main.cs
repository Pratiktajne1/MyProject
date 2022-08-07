using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism.Overriding.Base_single_Pro
{
    class Fan_main
    {
        static void Main(string[] args)
        {
            int a;
            string b, c;
            Console.WriteLine("enter fan blade ,name and color");
            a = int.Parse(Console.ReadLine());
            b = Console.ReadLine();
            c = Console.ReadLine();

            Havells havells = new Havells(a, b, c);
           
            
        }
    }
}
