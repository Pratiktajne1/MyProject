using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Abstract_and_Interface.Qus_2
{
    class Child_class : Abtract_class,IADDable
    {
        int num1, num2;
        public override void ADD(int a)
        {
            this.num1 = a;     
        }
        public void ADD_1(int b)
        {
            this.num2 = b; 
        }
        public void Addition()
        {
            Console.WriteLine("Addition is :- " + (this.num1 + this.num2));
        }
    }
}
