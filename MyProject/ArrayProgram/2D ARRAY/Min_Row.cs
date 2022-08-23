using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY
{
    class Min_Row
    {
        public static void Display(int [,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int min =a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (min > a[i, j])
                    {
                        min = a[i, j];
                    }
                    Console.Write(a[i, j ]+ "  ");
                }
                Console.Write("   Row min is = " + min);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("enter array");
            int[,] a = new int[size, size];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Min_Row.Display(a);

        }
    }
}
