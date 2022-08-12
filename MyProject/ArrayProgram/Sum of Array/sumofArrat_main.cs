using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Sum_of_Array
{
    class sumofArrat_main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int size = int.Parse(Console.ReadLine());
            float[] k = new float[size];
            for(int i=0;i<k.Length;i++)
            {
                k[i] = float.Parse(Console.ReadLine());
            }
            sumOfarray SumOfarray = new sumOfarray();
            SumOfarray.Sum(k);
        }



    }
}
