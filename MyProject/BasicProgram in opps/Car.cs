using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram_in_opps
{
    class Car
    {
        public int Model_no;
        public string car_name;
        public int car_price;
        public string car_color;
            
        static void Main(string[] args)
        {
            Car Bmw = new Car();
            Car Ford = new Car();
            Car Honda = new Car();

            Bmw.car_name = "BMW";
            Bmw.Model_no = 291;
            Bmw.car_price = 870000;
            Bmw.car_color = "blue";

            Ford.car_name = "FORD";
            Ford.Model_no = 1238;
            Ford.car_price = 800000;
            Ford.car_color = "black";

            Honda.car_name = "HONDA";
            Honda.Model_no = 321;
            Honda.car_price = 670000;
            Honda.car_color = "red";

            Console.WriteLine($"{Bmw.car_name} ... {Bmw.car_color} ... {Bmw.car_price} ...{Bmw.Model_no}");
            Console.WriteLine($"{Ford.car_name} ... {Ford.car_color} ... {Ford.car_price} ...{Ford.Model_no}");
            Console.WriteLine($"{Honda.car_name} ... {Honda.car_color} ... {Honda.car_price} ...{Honda.Model_no}");
        }
    }
}
