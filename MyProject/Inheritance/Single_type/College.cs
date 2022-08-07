using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Single_type
{
    class College
    {
        internal static string branch;
        internal static string College_name;

        public void Show()
        {
            Console.WriteLine($"student brance => {branch} \nCollege Name => {College_name}");
        }
    }
}
