using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_Qus__2.Qus_3
{
    class Kaprekar
    {
        int r,i,count=0,sum;
        public Kaprekar(int num)
        {
            i = num * num;
            int temp = num;
            
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            int pW = 1;

            for(int j =1; j<=count; j++)
            {
                pW = pW * 10;
            }
            int div = i / pW;
            r = i % pW;
            sum = div + r;
            if(sum == temp)
            {
                Console.WriteLine("Kaprekar");
            }
            else
            {
                Console.WriteLine("not Kaprekar");
            }

        }

    }
}
