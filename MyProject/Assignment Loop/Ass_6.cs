using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment_Loop
{
    class Ass_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number ");
            int num,sum=0;
            num = int.Parse(Console.ReadLine());

            for(int i=1; i<=num; i++)
            {
                if(i%2==0) 
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"addition of all even number is :- {sum}");

        }
    }
}
