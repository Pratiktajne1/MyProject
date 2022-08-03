using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_Qus__2.Qus_3
{
    class Main_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            Kaprekar K = new Kaprekar(num);
        }
    }
}
