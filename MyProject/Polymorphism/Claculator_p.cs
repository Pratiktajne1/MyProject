using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism
{
    class Claculator_p
    {
        public void Display(int a , int b)
        {
            Console.WriteLine("add is :- " + (a + b));
        }
        public void Display(double a , double b)
        {
            Console.WriteLine("Sub is :- " + (a - b));
        }
        public void Display(float a ,float b)
        {
            Console.WriteLine("div is :- " + (a / b));
        }
        public void Display(long a, long b)
        {
            Console.WriteLine("mult is :- " + (a * b));
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("***********Claculation************");
            Console.WriteLine();
        }
    }
}
