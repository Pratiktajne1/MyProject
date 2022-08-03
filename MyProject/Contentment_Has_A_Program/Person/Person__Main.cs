using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Person
{
    class Person__Main
    {
        static void Main(string[] args)
        {
            Person P = new Person();

            P.Id = 14;
            P.Name = "pratik";

            P.Add = new Address();
            P.Add.Pincode = 444444;
            P.Add.City = "Nagpur";

            Console.WriteLine($"id = {P.Id} \nName = {P.Name} \npincode = {P.Add.Pincode} \ncity = {P.Add.City}");
        }
    }
}
