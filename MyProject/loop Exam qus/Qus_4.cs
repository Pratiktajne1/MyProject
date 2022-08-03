using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_qus
{
    class Qus_4
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3;
            num3 = num1 + num2;

            Console.Write("\t" + num1);
            Console.Write("\t" + num2);
            for(int i=3; i<=20;i++)
            {
                Console.Write("\t" + num3);
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
                
            }
        }
    }
}
