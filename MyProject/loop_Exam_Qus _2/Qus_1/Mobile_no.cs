using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_Qus__2.Qus_1
{
    class Mobile_no
    {
        long num,r;
        
        public Mobile_no(long num)
        {
            this.num = num;
            
            this.Mobile_display();
        }
        public void Mobile_display()
        {
            long j;
            for (long i=1;i<=10;i++)
            {
                long count = 0;
                for(j=num;j>0;j=j/10)
                {
                    r = j % 10;
                    if(r==i)
                    {
                        count++;
                    }
                }
                if(count !=0)
                {
                    Console.WriteLine($"the frequency of {i} is {count}");
                }
            }          
        }

    }
}
