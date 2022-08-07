using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism.Overriding.Base_single_Pro
{
    class Fan
    {
        int blade;
        public Fan(int a)
        {
            this.blade = a;
            Console.WriteLine("Fan blade is :- " + this.blade);
        }
    }
}
