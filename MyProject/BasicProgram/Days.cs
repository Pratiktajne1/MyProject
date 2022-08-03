using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Days
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("enter any day number");

            day = Convert.ToInt32(Console.ReadLine());

            if(day >=1 && day <= 7 )
            {
                if(day==1)
                {
                    Console.WriteLine("Monday");
                }
                else if(day==2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if(day==3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if(day==4)
                {
                    Console.WriteLine("Thursday");
                }
                else if(day==5)
                {
                    Console.WriteLine("Friday");
                }
                else if(day==6)
                {
                    Console.WriteLine("Saturday");
                }
                else
                {
                    Console.WriteLine("Sunday");
                }
            }
            else
            {
                Console.WriteLine("enter between 1 to 7");
            }
        }
    }
}
