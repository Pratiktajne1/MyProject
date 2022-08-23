using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY.Sparse
{
    class Sparse_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter array");
            int[,] ar = new int[a, a];
            for(int i=0;i<ar.GetLength(0);i++)
            {
                for(int j=0;j<ar.GetLength(1);j++)
                {
                    ar[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Sparse S = new Sparse();
            bool flag=S.Display(ar);
            if(flag == true)
            {
                Console.WriteLine("not Sparse");
            }
            else
            {
                Console.WriteLine("Sparse");
            }
        }
    }
}
