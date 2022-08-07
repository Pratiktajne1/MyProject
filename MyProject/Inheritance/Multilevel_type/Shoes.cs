using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Multilevel_type
{
    class Shoes
    {
        internal static int size;
        internal string Shoes_brand;

        public void show(string s)
        {
            Shoes_brand = s;
            Console.WriteLine("Shoes size => " + size +"\nShoes brand => "+Shoes_brand);
        }
    }
   
}
