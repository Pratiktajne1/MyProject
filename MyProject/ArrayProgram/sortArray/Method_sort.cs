using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.sortArray
{
    class Method_sort
    {
        public int[] Display(int[] a)
        {
            int s = 0;
            for(int i=0;i<a.Length-1;i++)
            {
                int k = i;
                for(int j=1;j<a.Length;j++)
                {
                    if(a[k]<a[j])
                    {
                        s = a[j];
                        a[j] = a[k];
                        a[k] = s;
                    }

                }
                
            }
            return a;
        }
    }
}
