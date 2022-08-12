using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Min_and_Max
{
    class Min_Max_Main
    {
        static void Main(string[] args)
        {
            Max_int_Array max = new Max_int_Array();
            Min_Int_Array min = new Min_Int_Array();
            Console.WriteLine("enter size");
            int b = int.Parse(Console.ReadLine());
            int[] num = new int[b];
            Console.WriteLine("enter values");
            for(int i=0;i<num.Length;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int ma = max.Maximun(num);
            int mi = min.Minimum(num);
            Console.WriteLine("Maximum value is = " + ma);
            Console.WriteLine("Minimum value is = " + mi);

        }
    }
}
