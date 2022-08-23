using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY.Lower_Triangle
{
    class Lower_Triangle
    {
        public void Display(int[,] a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0; j<a.GetLength(1);j++)
                {
                    if(j>=i)
                    {
                        Console.Write(" " + a[i, j]);
                    }
                    else
                    {
                        Console.Write("  ");
                    }                          
                }
                Console.WriteLine();
            }
        }
    }
}
