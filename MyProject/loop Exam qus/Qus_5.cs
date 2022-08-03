using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_qus
{
    class Qus_5
    {
        static void Main(string[] args)
        {
            int num, num1, r, sum = 0;
            Console.WriteLine("enter any number ");
            num=int.Parse(Console.ReadLine());

            num1 = num;
            while(num>0)
            {
                r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
            if(num1 % sum==0)
            {
                Console.WriteLine("Harshad number");
            }
            else
            {
                Console.WriteLine("not Harshad number");
            }
        }
            
    }
}
