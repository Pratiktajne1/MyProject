using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Prime_Method
{
    class Main_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int s = int.Parse(Console.ReadLine());

            Prime_or_Not PN = new Prime_or_Not();
            bool a = PN.PrimeA(s);

            if(a==true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("not Prime");
            }
        }
    }
}
