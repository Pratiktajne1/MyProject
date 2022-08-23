using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus__12
{
    class Qus__12
    {
        public void Display(int[] a)
        {
            int d = 0;
            for (int i= 0;i< a.Length;i++)
            {
                if(a[i]>d)
                {
                    d = a[i];
                }
            }
            
            for (int i = 1; i <a.Length; i++)
            {
                int seq = a[i];
                
                for (int j = 1; j > 0; j++)
                {
                    if(j*j>d)
                    {
                        break;
                    }

                    if (j*j == seq)
                    {
                        Console.Write("  " + a[i]);
                        break;
                    }
                    
                }
            }
        }
    }
}
