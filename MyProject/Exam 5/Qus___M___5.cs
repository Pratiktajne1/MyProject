using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_5
{
    class Qus___M___5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());
            int[] ar = new int[a];
            for(int i=0;i<ar.Length;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] != 0)
                {
                    Console.Write("    " + ar[i]);
                }
            }
            for(int i=0;i<ar.Length;i++)
            {
                if (ar[i] == 0)
                {
                    Console.Write("    " + ar[i]);
                }
            }
        }
    }
}
