using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Abstract_and_Interface.Qus_1
{
    class Main_of_Interface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int a = Convert.ToInt32(Console.ReadLine());
            Child_of_Interface child_Of_Interface = new Child_of_Interface();
            child_Of_Interface.Display(a);
        }
    }
}
