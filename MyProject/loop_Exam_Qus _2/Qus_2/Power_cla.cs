using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_Qus__2.Qus_2
{
    class Power_cla
    {
        int b, i,g=1;
        public Power_cla()
        {
            Console.WriteLine("enter the base");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the index");
            i = int.Parse(Console.ReadLine());

            this.Power();
        }
        internal void Power()
        {
            for(int j=1;j<=i;j++)
            {
                g = g * b;
            }
            Console.WriteLine($"{b} power {i} = {g}");
        }
    }
}
