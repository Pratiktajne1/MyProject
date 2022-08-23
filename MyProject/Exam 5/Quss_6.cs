using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_5
{
    class Quss_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int a = Convert.ToInt32(Console.ReadLine());
            int[,] ar = new int[a,a];
            Console.WriteLine("enter array");
            for(int i=0;i<a;i++)
            {
                for(int j=0;j<a;j++)
                {
                    ar[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < a-1; i++)
            {              
             
                int h = ar[i,0];
                for (int j = i+1 ; j < a; j++)
                {
                    if (ar[i,j] > h)
                    {
                        int s = ar[i,j];
                        ar[i,j] = ar[i,0];
                        ar[i,0] = s;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a ; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("   " + ar[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
