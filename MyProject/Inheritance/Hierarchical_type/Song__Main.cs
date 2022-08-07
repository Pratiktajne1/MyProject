using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Hierarchical_type
{
    class Song__Main
    {
        static void Main(string[] args)
        {
            English E = new English();
            Hindi H = new Hindi();

            E.Display("Believer", "English", "Jimmy");
            E.Show(4);

            Console.WriteLine();
            Console.WriteLine("------------X------------");
            Console.WriteLine();

            H.Display("Jhoom", "Hindi", "Ali Zafar");
            H.Show(3);

        }
    }
}
