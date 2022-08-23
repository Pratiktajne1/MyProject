using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_5.Qus_4
{
    class Qus____4
    {
        static void Main(string[] args)
        {
            int c = 0, n = 0;
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());           
            Console.WriteLine("Enter array");
            int[] r = new int[a];  
            for (int i = 0; i < a; i++)
            {
                r[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            int f = 0;
            for (int j = 0; j < r.Length; j++)
            {
                for (int i = j + 1; i < r.Length; i++)
                {
                    if(r[i]<0)
                    {
                        temp = r[i];
                        r[i] = r[j];
                        r[j] = temp;
                    }
                }
            }
            for (int i = 0; i < r.Length; i++)
            {
                Console.Write("   " + r[i]);
            }
        }

    }
}

