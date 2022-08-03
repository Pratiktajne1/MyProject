using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());

            for(int i=1; i<=num; i++)
            {
                char ch = 'A';
                for(int j=1; j<=i; j++)
                {
                    if(i%2==0)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
