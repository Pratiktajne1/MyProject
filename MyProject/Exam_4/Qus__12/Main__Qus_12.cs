using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus__12
{
    class Main__Qus_12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter values");
            int[] ar = new int[a];
            for (int i = 0; i < a; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Qus__12 Q = new Qus__12();
            Q.Display(ar);
        }
    }
}
