using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Password
{
    class Password_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter password");
            string s = Console.ReadLine();
            Password p = new Password();
            p.Display(s);
        }
    }
}
