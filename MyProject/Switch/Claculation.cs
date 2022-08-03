using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Switch
{
    class Claculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any 2 number");
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("1. :- +\n2. :- -\n3. :- *\n4. /");
            char ch=Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':
                    Console.WriteLine("addition is :- " + (a + b));
                    break;
                case '-':
                    Console.WriteLine("Substraction is :- " + (a - b));
                    break;
                case '*':
                    Console.WriteLine("Multiplication is :- " + (a * b));
                    break;
                case '/':
                    Console.WriteLine("Division is :- " + (a / b));
                    break;
                default:
                    Console.WriteLine("enter valid choice");
                    break;
            }


        }
    }
}
