using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Count_event_odd
{
    class Main_even_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());
            int[] ar = new int[a];
            Console.WriteLine("enter value");
            for(int i=0;i<a;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Count_even_odd Eo = new Count_even_odd();

            Eo.Display(ar);
        }
    }
}
