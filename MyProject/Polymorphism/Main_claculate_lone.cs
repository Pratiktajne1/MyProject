using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism
{
    class Main_claculate_loan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter amount for personal loan");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("enter first amount for home loan");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter second amount for home loan");
            double num2 = double.Parse(Console.ReadLine());
            Claculate_loan C = new Claculate_loan();
            Console.WriteLine("enter month");
            double month = int.Parse(Console.ReadLine());
            C.Claculate_rate(num,month);
            C.Claculate_rate(num1, num2,month);

        }

    }
}
