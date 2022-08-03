using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Divide_5
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("enter any number");

            num = int.Parse(Console.ReadLine());

            if(num%5==0)
            {
                Console.WriteLine(num + " is divide by 5");
            }
            else
            {
                Console.WriteLine(num + " not divide by 5");
            }

        }
    }
}
