using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_Qus__2
{
    class Series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number ");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while(i<=num)
            {
                int b = i * i - 1;
                Console.Write(b + " ");
                i++;
            }

        }
    }
}
