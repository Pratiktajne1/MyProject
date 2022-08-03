using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_Qus__2
{
    class Loop_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());
            for(int i =1; i<=num; i++)
            {
                
                for(int j =i; j>=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
