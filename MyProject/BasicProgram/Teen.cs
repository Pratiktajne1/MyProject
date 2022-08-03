using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Teen
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter any age");
            age = int.Parse(Console.ReadLine());

            if(age>=18)
            {
                Console.WriteLine(" teenager");
            }
            else
            {
                Console.WriteLine(" Not Teenager");
            }
        }
    }
}
