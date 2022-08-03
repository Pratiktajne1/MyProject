using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_Qus__2
{
    class Loop_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());
            
            for(int i =num; i>=1;i--)
            {
                for (int j = 1; j < i; j++)
                    Console.Write(" ");
                for(int k =num; k>=i;k--)
                {
                    if (k % 2 != 0)
                        Console.Write("1");
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }
        }
    }
}
