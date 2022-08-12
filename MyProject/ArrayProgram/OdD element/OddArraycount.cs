using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.OdD_element
{
    class OddArraycount
    {
        public void Display(int[] a)
        {
            int g = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2 !=0)
                {
                    g++;
                }
            }
            Console.WriteLine("odd element count = " + g);
        }
    }
}
