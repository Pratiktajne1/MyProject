using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY.Sum_of_column
{
    class SumofColumn
    {
        public void Display(int[,] ar)
        {
            for(int i=0;i<ar.GetLength(0);i++)
            {
                int sum = 0;
                for(int j=0;j<ar.GetLength(1);j++)
                {
                    Console.Write("  " + ar[i, j]);
                    sum = sum + ar[j, i];
                }
                Console.Write("   sum= " + sum);
                Console.WriteLine();
            }

        }
    }
}
