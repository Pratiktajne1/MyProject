using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4
{
    class Qus_9
    {
        static void Main(string[] args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] + " ");
                i++;
            }

            Console.ReadLine();

        }
    }
}
