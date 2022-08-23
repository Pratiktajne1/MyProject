using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY.Avg_of_Row
{
    class Avg_of_row_main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("enter array");
            int[,] a = new int[size, size];
            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Avg_of_row AoR = new Avg_of_row();
            AoR.Display(a);
        }
    }
}
