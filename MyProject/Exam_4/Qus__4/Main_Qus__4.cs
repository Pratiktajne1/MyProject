using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus__4
{
    class Main_Qus__4
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            
          

            p.Brand = "reynolds";
            p.Caplength = 8;

            p.Refills = new Refill();
            p.Refills.InkColour = "red";
            p.Refills.length = 10;

            p.Refills.Nibtype = new Nib();

            p.Refills.Nibtype.Materialtype = "stainless steel";
            p.Refills.Nibtype.Width = 2;

            Console.WriteLine($"Brand = {p.Brand}\nCaplength = {p.Caplength}\n" +
                $"InkColor = {p.Refills.InkColour}\n" +
                $"length = {p.Refills.length}\nMaterialtype = {p.Refills.Nibtype.Materialtype}" +
                $"\nWidth = {p.Refills.Nibtype.Width}");
        }
    }
}
