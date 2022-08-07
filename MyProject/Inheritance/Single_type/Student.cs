using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Single_type
{
    class Student : College
    {
        string student_name;
        int age;
        float height;

        public Student(int a, float b, string c)
        {
            this.age = a;
            this.height = b;
            this.student_name = c;
        }
        public void display()
        {
            Console.WriteLine($"student age => {this.age} \nstudent name => {this.student_name} \nstudent height =>" +
                $"{height}");
        }
            





    }
}
