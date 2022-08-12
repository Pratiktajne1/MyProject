using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.sortArray
{
    class Main_Sort
    {
        static void Main(string[] args)
        {
            Method_sort M = new Method_sort();
            Console.WriteLine("enter size");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] ARR = new int[a];
            Console.WriteLine("enter value");
            for(int i=0;i<ARR.Length;i++)
            {
                ARR[i] = Convert.ToInt32(Console.ReadLine());
            }        
            int[] r = M.Display(ARR);
            for( int h=0;h<r.Length;h++)
            {
                Console.Write(" " + r[h]);
            }

        }
    }
}
