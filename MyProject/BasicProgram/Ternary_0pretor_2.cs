using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Ternary_0pretor_2
    {
        static void Main(string[] args)
        {
            int num;
            String result;

            Console.WriteLine("enter any number");
            num = int.Parse(Console.ReadLine());

            result = num > 0 ? "Positive number" : num < 0 ? "Negative number" : "number is zero";
            Console.WriteLine(result);
        }
    }
}
