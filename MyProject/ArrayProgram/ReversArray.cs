using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram
{
    class ReversArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value");
            int[] a = new int[size];
            for(int i = 0; i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.Write("  " + a[i]);
            }
           
        }

       
    }
}
