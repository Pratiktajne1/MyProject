using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_6
{
    class Qus__6__Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter array");
            int[] ar = new int[a];
            for(int i=0;i<a;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Qus_6__ Q = new Qus_6__();
            Q.Display(ar);
        }
    }
}
