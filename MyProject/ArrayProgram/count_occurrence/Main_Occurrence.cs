using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.count_occurrence
{
    class Main_Occurrence
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter values");
            int[] ar = new int[a];
            for(int i=0;i<a;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Count_Occurrence CO = new Count_Occurrence();
            CO.Display(ar);
        }
    }
}
