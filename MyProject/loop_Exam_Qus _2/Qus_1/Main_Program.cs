using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop_Exam_Qus__2.Qus_1
{
    class Main_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any mobile number");
            long num = long.Parse(Console.ReadLine());
            Mobile_no MN = new Mobile_no(num);
        }
    }
}
