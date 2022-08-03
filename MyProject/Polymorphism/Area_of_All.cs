using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism
{
    class Area_of_All
    {
        public void Area(float a)
        {
            Console.WriteLine("Area of Circle :-"+(3.14*a*a));
        }
        public void Area(double a, double b)
        {
            Console.WriteLine("Area of Triangle :- " + (0.5*a*b));
        }
        public void Area(int a, int b)
        {
            Console.WriteLine("Area of Rectangle :- " + (a*b));
        }
        public void Area(long a)
        {
            Console.WriteLine("Area of Square :- " + (a * a));
        }
        public void Area()
        {
            Console.WriteLine();
            Console.WriteLine("========X--&#&--X========");
            Console.WriteLine();
        }
    }
}
