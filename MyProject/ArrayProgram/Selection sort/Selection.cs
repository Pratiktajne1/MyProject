using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Selection_sort
{
    class Selection
    {
        public char[] Display(char[] a)
        {
            char temp;
            for (int i = 0; i < a.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if(a[k]>a[j])
                    {
                        k = j;
                    }
                }
                temp = a[k];
                a[k] = a[i];
                a[i] = temp;
            }
            return a;
        }
    }
}