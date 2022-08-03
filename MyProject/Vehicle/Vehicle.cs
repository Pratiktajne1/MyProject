using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Vehicle
{
    class Vehicle
    {
        public int M_no, No_Wheel;
        string Type_V;
        int avg = 0;
        public void Set_Details(int module_no, string Type_of_Vehicle, int No_of_wheel)
        {
            M_no = module_no;
            No_Wheel = No_of_wheel;
            Type_V = Type_of_Vehicle;
        }
        public void Avg()
        {
            if (No_Wheel % 2 == 0)
            {
                if (No_Wheel <= 4 && No_Wheel > 1)
                {
                    avg = 40;
                }
                else if (No_Wheel >= 5 && No_Wheel <= 14)
                {
                    avg = 20;
                }
                else if (No_Wheel > 14)
                {
                    avg = 10;
                }
            }    
        }
        public void GetDisplay()
        {
            Console.WriteLine($"M_no = {M_no} wheels = {No_Wheel} Type = {Type_V} avg = {avg}");
        }
        static void Main(string[] args)
        {
            Vehicle V = new Vehicle();
            Console.WriteLine("enter module no ,no of wheels and vehicle typr");
            int a, bs;
            string c;
            a = int.Parse(Console.ReadLine());
            bs = int.Parse(Console.ReadLine());
            c = Console.ReadLine();

            V.Set_Details(a, c,bs);
            V.Avg();
            V.GetDisplay();
           
        



        }

    }
}
