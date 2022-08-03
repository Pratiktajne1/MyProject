using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism
{
    class Claculate_loan
    { 
        public void Claculate_rate(double num,double month)
        {
            Console.WriteLine("total is :- " +(num * 0.1 * month));
        }
        public void Claculate_rate(double num1 ,double num2,double month)
        {
            if(month >6)
            {
                Console.WriteLine("total is :- " + (0.3*month*num2));
            }
            else
            {
                Console.WriteLine("total is :- " + (num1 * month * 0.15));
            }
        }
    }
}
