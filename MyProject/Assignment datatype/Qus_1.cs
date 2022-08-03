using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment_datatype
{
    class Qus_1
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any year");
            int a = int.Parse(Console.ReadLine());

            if(a%4==0)
            {
                if(a%100==0 && a%400!=0)
                {
                    Console.WriteLine("centure year");
                }
                else if(a%400==0)
                {
                    Console.WriteLine("leep year");
                }

            }
        }
       
    }
}
