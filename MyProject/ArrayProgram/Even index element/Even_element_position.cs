using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Even_index_element
{
    class Even_element_position
    {
        public void Display(int[] a)
        {
            int[] ar = new int[a.Length];
            for(int i=0;i<a.Length;i+=2)
            {
                ar[i]= a[i];
                
            }
            Console.WriteLine("even position is");
            for(int j=0;j<ar.Length;j++)
            {
                if(ar[j]==0)
                {
                    continue;
                }
                Console.WriteLine(ar[j]);
            }
        }
    }
}
