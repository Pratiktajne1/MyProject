using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY.N_in_2D
{
    class N_main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int size = int.Parse(Console.ReadLine());
            int[,] a = new int[size, size];
            Console.WriteLine("enter array");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int  j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());               
                }              
            }
            N n = new N();
            n.Display(a);

        }
    }
}
