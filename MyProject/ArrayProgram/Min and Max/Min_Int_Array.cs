using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Min_and_Max
{
    class Min_Int_Array
    {
        public int Minimum(int[] a)
        {
            int b = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (b > a[i])
                {
                    b = a[i];
                }
            }
            return b; 
        
        }
    }
}
