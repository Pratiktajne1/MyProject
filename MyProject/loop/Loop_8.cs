using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_8
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter any no.");
            int num = int.Parse(Console.ReadLine());
            bool v = true;
            for (int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    v = false;
                    break;
                }
            }
            if(v==true)
            {
                Console.WriteLine($"number is prime");
            }
            else if(v==false)
            {
                Console.WriteLine("number is not prime");
            }

        }
    }
}
