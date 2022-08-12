using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Method_Array
{
    class Main_ArrayOddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            short a = Convert.ToInt16(Console.ReadLine());
            int[] Arr = new int[a];
            Console.WriteLine("enter value");
            for(int i=0; i<a;i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            OddOrEventArray.Array_1(Arr);
        }
    }
}
