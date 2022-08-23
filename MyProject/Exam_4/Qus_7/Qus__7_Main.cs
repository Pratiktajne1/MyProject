using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_7
{
    class Qus__7_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter values");
            int[] ar = new int[a];
            for(int i=0;i<a;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Qus__7 Q = new Qus__7();
            Q.Display(ar);
        }
    }
}
