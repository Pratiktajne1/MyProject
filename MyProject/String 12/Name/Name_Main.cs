using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Name
{
    class Name_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string s = Console.ReadLine();
            Name_1 n = new Name_1();
            n.Display(s);
        }
    }
}
