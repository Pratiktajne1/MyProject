using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_5.Qus_1
{
    class Qus_1
    {
        static void Main(string[] args)
        {
            int c=0,n=0;
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter size");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array");
            int[] r = new int[a];
            int[] w = new int[z];
            int f = a + z;
            int[] m = new int[f];
            for (int i = 0; i < a; i++)
            {
                r[i] = int.Parse(Console.ReadLine());
            }
            for (int t = 0; t < z; t++)
            {
                w[t] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < m.Length; j++)
            {
                if (j % 2 == 0)
                {              
                    m[j] = r[c];
                    c++;                
                }
                else
                {                  
                    m[j] = w[n];
                    n++;
                }
            }
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write("   " + m[i]);
            }
        }



    }
}
