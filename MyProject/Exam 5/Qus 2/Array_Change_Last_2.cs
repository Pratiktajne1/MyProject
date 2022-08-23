using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_5.Qus_2
{
    class Array_Change_Last_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int b, c;
            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    b = a[i];
                    a[i] = a[size - 1];
                    a[size - 1] = b;
                }
                if (i == 1)
                {
                    c = a[i];
                    a[i] = a[size - 2];
                    a[size - 2] = c;
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write("    " + a[i]);
            }
        }
    }
}
