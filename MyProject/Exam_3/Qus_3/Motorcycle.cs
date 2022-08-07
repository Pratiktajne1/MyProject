using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3.Qus_3
{
    class Motorcycle : Cycle
    {
        int egine;
        public Motorcycle(int a,int b):base(a)
        {
            this.egine = b;    
        }
        public override void TyreAndWheels()
        {
            base.TyreAndWheels();
            Console.WriteLine($"total wheels use in motorcycle is {base.wheels} " +
                $"and total tyre use in motorcycle is {base.tyre}");
        }
        public void Engine()
        {
            Console.WriteLine(" "+this.egine + " Engine use in motorcycle ");
        }
    }
}
