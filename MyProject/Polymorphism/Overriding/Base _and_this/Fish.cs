using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism.Overriding.Base__and_this
{
    class Fish
    {
        int leg=0;
        public virtual void Swimming(int leg)
        {
            Console.WriteLine($"'Fish; can swim and 'Fish' have {this.leg} legs");
        }
    }
}
