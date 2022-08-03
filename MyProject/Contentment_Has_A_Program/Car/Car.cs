using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Car
{
    class Car
    {
        int model_no;
        string name;
        int price;
        Engine en;

        public Car(int model_no,string name,int price,Engine en)
        {
            this.model_no = model_no;
            this.name = name;
            this.price = price;
            this.en = en;

            this.Display();
        }
        public void Display()
        {
            Console.WriteLine($"model no = {this.model_no} \nname = {this.name} \nprice = {this.price}");
            en.Display();
        }
    }
}
