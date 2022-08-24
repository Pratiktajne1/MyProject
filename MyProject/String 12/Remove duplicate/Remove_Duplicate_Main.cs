using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Remove_duplicate
{
    class Remove_Duplicate_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            Remove_Duplicate D = new Remove_Duplicate();
            D.Display(s);
        }
    }
}
