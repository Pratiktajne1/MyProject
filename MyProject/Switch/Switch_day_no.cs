﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Switch
{
    class Switch_day_no
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter any number between 1 to 7");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("enter valid number");
                    break;

            }

        }
    }
}
