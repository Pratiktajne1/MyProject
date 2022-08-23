using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_5.Qus_7
{
    class Qus_7
    {
        public void Display(int[][] a)
        {
            for(int i =0; i<a.GetLength(0);i++)
            {
                int g = 0;
                for(int j = 0; j<a[i].Length;j++)
                {
                    Console.Write(" "+a[i][j]);
                    if(g<a[i][j])
                    {
                        g = a[i][j];
                    }
                }
                Console.Write("          Largest in row = " + g);
                Console.WriteLine();
            }
        }
    }
}
