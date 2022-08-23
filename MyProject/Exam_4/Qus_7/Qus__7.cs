using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_7
{
    class Qus__7
    {
        public void Display(int[] a)
        {
           
           
            for (int i=0;i<a.Length;i++)
            {
                bool flag = true;
                for (int m = i -1;m>=0 ;m--)
                {
                    if(a[m]==a[i])
                    {
                      
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    for (int k = 0; k <a.Length; k++)
                    {
                        Console.WriteLine("     " + a[k]);

                    }
                }


            }
            
        }
    }
}
