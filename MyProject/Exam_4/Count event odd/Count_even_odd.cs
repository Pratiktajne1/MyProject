using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Count_event_odd
{
    class Count_even_odd
    {
        public void Display(int[] a)
        {
            int e = 0, o = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    e++;
                }
                else
                {
                    o++;
                }
            }
            Console.WriteLine("even number count is :- " + e);
            Console.WriteLine("odd number count is :- " + o);
        }
    }
}
