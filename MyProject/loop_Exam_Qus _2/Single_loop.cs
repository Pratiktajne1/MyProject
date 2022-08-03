using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_Qus__2
{
    class Single_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int count =0;
            for(int i =1;i<=num; )
            {
                if (count < i)
                {
                    Console.Write(i);
                    count++;
                }
                else
                {
                    Console.WriteLine();
                    count = 0;
                    i++;
                }  
            }
        }
    }
}
