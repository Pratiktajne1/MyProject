using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_3
{
    class Qus_3_Dub_Main
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());
            char[] ar = new char[a];
            Console.WriteLine("enter value");
            for (int i = 0; i < a; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Qus_3_Dub QD = new Qus_3_Dub();

            QD.Display(ar);
        }
    }
}
