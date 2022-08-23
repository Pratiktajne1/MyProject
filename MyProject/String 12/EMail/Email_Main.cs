using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.EMail
{
    class Email_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter email id");
            string s = Console.ReadLine();
            EMail n = new EMail();
            n.Display(s);
        }
    }
}
