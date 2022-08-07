using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism.Overriding.Base_single_Pro
{
    class Havells : Fan
    {
        public Havells(int a,string name,string color) : base(a)
        {
            Console.WriteLine($"fan name => {name} \nfan color => {color}");

        }
    }
}
