using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Ternary_opretor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");

            int num;
            num = Convert.ToInt32(Console.ReadLine());

            String result = num % 2 == 0 ? "Number is even" : " number is odd";
            Console.WriteLine(result);
        }
    }
}
