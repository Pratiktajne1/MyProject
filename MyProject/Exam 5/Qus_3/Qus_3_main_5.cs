using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_5.Qus_3
{
    class Qus_3_main_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array");
            int[] ar = new int[a];
            for(int i=0;i<a;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Qus_3 Qs = new Qus_3();
            Qs.Display(ar);
        }
       
    }
}

