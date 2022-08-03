using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_14
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter any no.");
            num = int.Parse(Console.ReadLine());
             for(int i =1; i<=num;i++)
            {
                
                for(int j=1; j<=i;j++)
                {
                   if(j%2!=0)
                    {
                        Console.Write("1");
                    }
                   else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }

        }
        
    }
}
