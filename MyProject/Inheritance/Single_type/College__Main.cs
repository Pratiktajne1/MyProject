using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Single_type
{
    class College__Main
    {
        static void Main(string[] args)
        {
            Student s = new Student(21,5.9f,"pratik");
            College.branch = "ETC";
            College.College_name = "RGCER";

            s.Show();
            s.display();
        }
    }
}
