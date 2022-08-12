using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.OdD_element
{
    class Oddelementcount_main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());

            int[] ar = new int[a];
            Console.WriteLine("enter value");

            for(int i=0;i<ar.Length;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            OddArraycount odd = new OddArraycount();
            odd.Display(ar);
        }
    }
}
