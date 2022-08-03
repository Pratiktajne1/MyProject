using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_qus
{
    class Qus_3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                int f ;
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    f = i * i;
                    Console.WriteLine(f);
                }
            }
        }

    }
}
