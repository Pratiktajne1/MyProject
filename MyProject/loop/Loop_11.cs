using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number for '+'");
            int num = int.Parse(Console.ReadLine());
            int num2 = num / 2;
            for(int i=1;i<=num;i++)
            {
                for(int j=1; j<=num;j++)
                {
                    if(i==num2 || j==num2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
