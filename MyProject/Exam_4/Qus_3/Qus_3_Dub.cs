using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_3
{
    class Qus_3_Dub
    {
        public void Display(char[] a)
        {
            int n = 0;int g=0;
            for(int i=0;i<a.Length;i++)
            {
                int s = 0;
                bool flag = true;
                for(int j=i-1;j>=0;j--)
                {
                    if(a[i]==a[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag==true)
                {
                    for(int k=0;k<a.Length;k++)
                    {
                        if (a[i] == a[k])
                        {
                            s++;
                        }

                    }
                   

                }
                if (n > s)
                {
                    n = s;
                    g = i;
                }

            }
            Console.WriteLine("smallest frequency is " + n + " and value is " + a[g]) ;
        }
    }
}
 