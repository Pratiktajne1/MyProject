using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Encapsulation
{
    class Main_Program
    {
        static void Main(string[] args)
        {
            Car C = new Car();
            C.Module_no = 12;
            C.Name = "Honda";
            C.Price = 1200001.23f;
            C.Speed = 300;

            Console.WriteLine($"{C.Module_no}   {C.Name}   {C.Price}    {C.Speed}");

            
        }
    }
}
