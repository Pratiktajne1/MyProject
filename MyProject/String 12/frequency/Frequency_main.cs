using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.frequency
{
    class Frequency_main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any word");
            string n = Console.ReadLine();
            Frequency F = new Frequency();
            F.Display(n);

        }
    }
}
