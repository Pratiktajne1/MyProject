using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=num; i++)
            {
                for(int j=1; j<=num;j++)
                {
                    if(i==1 ||j==1 || i==num ||j==num)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
