using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism
{
    class Main_program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 int value ");
            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2 long value ");
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2 double value ");
            double e = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2 float value ");
            float g = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());

            Claculator_p Cp = new Claculator_p();
            Cp.Display();
            Cp.Display(a, b);
            Cp.Display(c, d);
            Cp.Display(e, f);
            Cp.Display(g, h);
        }
    }
}
