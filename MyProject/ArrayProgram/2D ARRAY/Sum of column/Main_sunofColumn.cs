using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY.Sum_of_column
{
    class Main_sunofColumn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("enter column");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("enter array");
            int[,] ar = new int[row,column];
            for(int i=0;i<ar.GetLength(0);i++)
            {
                for(int j=0;j<ar.GetLength(1);j++)
                {
                    ar[i,j] = int.Parse(Console.ReadLine());
                }
                
            }
            SumofColumn soc = new SumofColumn();
            soc.Display(ar);
        }
    }
}
