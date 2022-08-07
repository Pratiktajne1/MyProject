using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Multilevel_type
{
    class Sport : Shoes
    {
        internal string Sport_type;
        
        public void Display(string S)
        {
            Sport_type = S;
            Console.WriteLine("Sport Type => " + Sport_type);
        }
    }
}
