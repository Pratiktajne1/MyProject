using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Even_Odd_Sep
{
    class Even_ODD_SEp
    {
        public void Display(int[] a)
        {
            int k = 0;
            int d = 0;
            int[] even = new int[a.Length];
            int[] odd = new int[a.Length];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    even[k] = a[i];
                    k++;
                }
                else
                {
                    odd[d] = a[i];
                    d++;
                }
            }
            for(int i=0;i<=k;i++)
            {
                Console.Write("    " + even[i]);
            }
            Console.WriteLine();
            for (int i = 0; i <= d; i++)
            {
                Console.Write("    " + odd[i]);
            }
        }
    }
}
