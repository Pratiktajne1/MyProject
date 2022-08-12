using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Sum_of_Array
{
    class sumOfarray
    {
        public void Sum(float[] a)
        {
            float s = 0.0f;
            for(int i=0;i<a.Length;i++)
            {
                s = a[i] + s;
            }
            Console.WriteLine("sum is = " + s);
        }
    }
}
