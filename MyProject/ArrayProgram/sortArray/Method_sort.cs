using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.sortArray
{
    class Method_sort
    {
        public int[] Display(int[] a)
        {
            int s ;
            for(int i=0;i<a.Length-1;i++)
            {
               
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]>a[j])
                    {
                        s = a[j];
                        a[j] = a[i];
                        a[i] = s;
                    }

                }
                
            }
            return a;
        }
    }
}
