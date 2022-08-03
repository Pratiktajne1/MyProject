using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Even_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num;
            num = int.Parse(Console.ReadLine());

            if(num%2==0 && !(num>=5 && num<=10))
            {
                Console.WriteLine("hi even");
            }
            else if((num>=2 && num<=6) && num%2 !=0)
            {
                Console.WriteLine("hello odd");
            }
            else if((num<=10 && num>=5) && num%2==0 )
            {
                Console.WriteLine("only even");
            }
            else if(num%2!=0 && !(num>=2 && num<=6))
            {
                Console.WriteLine("only odd");
            }
        }
    }
}
