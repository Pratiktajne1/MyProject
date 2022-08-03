using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism
{
    static class Static_overloading
    {
        
        static void Shop()
        {
          
            double BP = 10000;
            double profit = BP + (BP * (20 / 100));
            Console.WriteLine("Profit is :- " + profit);
        }
    }
}
