using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Frequency
{
    class Frequency_main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());
            int[] ar = new int[a];
            Console.WriteLine("enter array");
            for(int i=0;i<a;i++)
            {
                ar[i]=int.Parse(Console.ReadLine());
            }
            Frequency F = new Frequency();
            F.Display(ar);

        }
    }
}
