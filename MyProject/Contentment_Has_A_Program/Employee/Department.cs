using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Employee
{
    class Department
    {
        int id;
        string name;

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.Display();
        }
        public void Display()
        {
            Console.WriteLine($"id ==> {id} \n name ==> {name} ");
        }
    }
}
