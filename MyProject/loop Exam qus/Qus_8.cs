using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_qus
{
    class Qus_8
    {
        static void Main(string[] args)
        {
            int  num, t, v, sum = 0, b = 1, num2;
            Console.WriteLine("enter any number");
            num = Convert.ToInt32(Console.ReadLine());
            t = num;
            num2 = num;
            while (num > 0)                            //145     
            {
                v = num % 10;                          //v=5              v=4
                for (int i = 1; i <= v; i++)
                {
                    b = b * i;                      // b=1=2=6=24=120     b=24
                }
                sum = sum + b;                      //sum=120             sum=144
                b = 1;                               //b=1;
                num = num / 10;                      //num=14              num=1

            }
            if (num2 == sum)
            {
                Console.WriteLine("Krishnamurthy number");
            }
            else
            {
                Console.WriteLine("not Krishnamurthy number");
            }


        }
    }
}
