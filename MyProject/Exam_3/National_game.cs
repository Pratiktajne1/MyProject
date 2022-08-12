using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3
{
    class National_game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("India\nChina\nBangladesh\nItaly\nUnited States\n\nenter country name\n");
            string country_name = Console.ReadLine();
            switch (country_name)
            {
                case "India" :
                    Console.WriteLine("India National game is Hockey");
                    break;
                case "China":
                    Console.WriteLine("China National game is Table Tennis");
                    break;
                case "Bangladesh":
                    Console.WriteLine("Bangladesh National game is Kabaddi");
                    break;
                case "Italy":
                    Console.WriteLine("Italy National game is Football");
                    break;
                case "United States":
                    Console.WriteLine("United States National game is baseball");
                    break;
                default:
                    Console.WriteLine("Enter correct Country");
                    break;
            }



        }
    }
}
