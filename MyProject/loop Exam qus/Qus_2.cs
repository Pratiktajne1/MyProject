using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_qus
{
    class Qus_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number for factor");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine($"Factor of {num} = {i}");
                }
            }


        
        }
    }
}
