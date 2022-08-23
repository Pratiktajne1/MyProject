using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_6
{
    class Qus_6__
    {
        public void Display(int[] a)
        {
            int j =0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]!=0)
                {
                    a[j] = a[i];
                    j++;
                    
                }
            }
            int k = j;
            for(j=0;j<a.Length;j++)
            {
                if(j>k)
                {
                    a[j] = 0;
                }
                Console.WriteLine("       "+a[j]);

            }
           
        }
    }
}
