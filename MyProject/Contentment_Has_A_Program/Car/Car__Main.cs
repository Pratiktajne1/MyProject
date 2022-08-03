using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Car
{
    class Car__Main
    {
        static void Main(string[] args)
        {
            Car c = new Car(110, "I10", 10000, new Engine("electric"));
        }
    }
}
