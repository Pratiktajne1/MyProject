using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Selection_sort
{
    class Selection_Main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter Size");
            int a = int.Parse(Console.ReadLine());
            char[] ar = new char[a];
            Console.WriteLine("enter values");
            for(int i=0;i<a;i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Selection S = new Selection();
            
            char [] c =S.Display(ar);
            Console.WriteLine("Sorting array");
            for(int i=0;i<ar.Length;i++)
            {
                Console.WriteLine("   " + c[i]);
            }
        }
     
    }
}
