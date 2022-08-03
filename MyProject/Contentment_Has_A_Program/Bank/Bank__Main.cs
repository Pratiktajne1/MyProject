using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Bank
{
    class Bank__Main
    {
        static void Main(string[] args)
        {
            Bank B = new Bank();
            B.Brand = "Indian bank";
            B.Color = "Blue";
            B.Price = 1234;
           

            B.P = new Pen();

            B.P.Color = "red";
            B.P.Name = "Cello";
            B.P.Length = 3;
            B.P.Type = "any type";

            Console.WriteLine($"brand = {B.Brand} \nbank color = {B.Color} \nPrice = {B.Price} \n" +
                $"pen color = {B.P.Color} \npen name = {B.P.Name} \npen length = {B.P.Length} " +
                $"\npen type = {B.P.Type}");

        }
    }
}
