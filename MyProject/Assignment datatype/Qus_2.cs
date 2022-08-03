using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment_datatype
{
    class Qus_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());

            if(num%5==0 && num%11==0)
            {
                Console.WriteLine("this number divisible by 5 and 11");
            }
        }
    }
}
