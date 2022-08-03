using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment_Loop
{
    class Ass_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");

            int num, sum = 0;
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num ; i++)
            {
                if(i%2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("addition of all odd number :-" + sum);
        }

    }
}