using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY.Avg_of_Row
{
    class Avg_of_row
    {
        public void Display(int[,] a)
        {
            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                int Sum = 0;
                int count = 0;
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    Console.Write(a[i, j]+"   ");
                    Sum = Sum + a[i, j];
                    count++;
                }
                
                Console.Write("   Sum "+Sum+" and count "+count+ " and Avg is "+(Sum/count));
                Console.WriteLine();
            }
        }
    }
}
