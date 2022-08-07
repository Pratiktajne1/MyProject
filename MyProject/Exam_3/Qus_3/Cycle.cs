using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3.Qus_3
{
    class Cycle
    {
        protected int wheels;
        protected int tyre;

        public Cycle(int a)
        {
            this.wheels = a;
            this.tyre = a;
        }
        public virtual void TyreAndWheels()
        {
            Console.WriteLine($"total wheels use in cycle is {this.wheels} " +
                $"and total tyre use in cycle is {this.tyre}");
        }

    }
}
