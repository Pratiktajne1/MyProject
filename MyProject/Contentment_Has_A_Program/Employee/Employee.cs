using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Employee
{
    class Employee
    {
        int id;
        string name;
        float salary;
        Department D;

        public Employee(int id, string name, float salary,Department D)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.D = D;

            this.Display();
        }
        public void Display()
        {
            Console.WriteLine($"id ==> {id} \nname ==> {name} \nsalary ==> {salary}");
        }
    }
}
