using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Blood_donation
    {
        static void Main(string[] args)
        {
            int age;
            float weight;

            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Weight");
            weight = float.Parse(Console.ReadLine());

            if(age>18)
            {
                if(weight>50)
                {
                    Console.WriteLine("you are eligible for blood donation");
                }
                else
                {
                    Console.WriteLine("Weight is 50 or less than 50");
                }
            }
            else
            {
                Console.WriteLine("Age is less 19");
            }
        }
  
    }
}
