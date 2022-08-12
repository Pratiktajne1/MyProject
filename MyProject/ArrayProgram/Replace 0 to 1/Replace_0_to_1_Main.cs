using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Replace_0_to_1
{
    class Replace_0_to_1_Main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Array");
            int[] ar = new int[a];
            for(int i=0;i<a;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Replace_0_to_1 R01 = new Replace_0_to_1(ar);

        }
    }
}
