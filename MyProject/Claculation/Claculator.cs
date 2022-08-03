using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Claculation
{
    class Claculator
    {
        double num1, num2,add,sub,mul;
        
        public Claculator()
        {
            this.num1 = num1;
            this.num2 = num2;

        }
        public Claculator(double num1,double num2) : this()
        {
            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            this.Add();
            this.Sub();
            this.Mult();
        }
        public void Add()
        {
            Console.WriteLine("addition is : - " + add);
        }
        public void Sub()
        {
            Console.WriteLine("sub is :- " + sub);
        }
        public void Mult()
        {
            Console.WriteLine("mult is :- " + mul);
        }
    }
}
