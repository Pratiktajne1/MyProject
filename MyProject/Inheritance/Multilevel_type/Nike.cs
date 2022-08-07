using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Multilevel_type
{
    class Nike :Sport
    {
        internal double price;
        internal string Shoes_Color;
        internal string Shose_type;

        public void show2(double a,string b, string c)
        {
            price = a;
            Shoes_Color = b;
            Shose_type = c;
            Console.WriteLine($"price => {price} \nShoes Color => {Shoes_Color} \nShose Type => {Shose_type}");
        }

    }
}
