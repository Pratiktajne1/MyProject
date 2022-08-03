using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism
{
    class Main_program_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter float value for AOC");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("enter 2 double values for AOT");
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("enter 2 int values for AOR");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("enter long value for AOS");
            long f = long.Parse(Console.ReadLine());

            Area_of_All AOA = new Area_of_All();

            AOA.Area();
            AOA.Area(a);
            AOA.Area(b,c);
            AOA.Area(d,e);
            AOA.Area(f);
            AOA.Area();
        }
    }
}
