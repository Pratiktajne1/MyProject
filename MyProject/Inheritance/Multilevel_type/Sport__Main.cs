using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Multilevel_type
{
    class Sport__Main
    {
        static void Main(string[] args)
        {
            Nike N = new Nike();
            Shoes.size = 8;
            N.show("Nike");
            N.Display("Football");
            N.show2(8000, "Black", "Boy/Man");
        }
    }
}
