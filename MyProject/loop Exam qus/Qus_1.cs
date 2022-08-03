using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_qus
{
    class Qus_1
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=100; i++)
            {
                if(i%5==0 || i%10==0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
