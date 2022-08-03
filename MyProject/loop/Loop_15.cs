using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_15
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter any no.");
            num = int.Parse(Console.ReadLine());
            for (int i = num; i <= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }



        }
    }
}
