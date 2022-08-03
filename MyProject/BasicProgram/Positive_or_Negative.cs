using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Positive_or_Negative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any number");
            num = int.Parse(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine(num + " is positive");
            }
            else if(num<0)
            {
                Console.WriteLine(num + " is Negative");
            }
            else
            {
                Console.WriteLine(num + " is zero");
            }

        
        }
    }
}
