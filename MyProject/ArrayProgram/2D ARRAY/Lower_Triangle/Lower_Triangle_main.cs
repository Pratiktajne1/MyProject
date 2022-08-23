using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY.Lower_Triangle
{
    class Lower_Triangle_main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int size = int.Parse(Console.ReadLine());
            int[,] a = new int[size, size];
            Console.WriteLine("enter array");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Lower_Triangle L = new Lower_Triangle();
            L.Display(a);

        }
    }
}
