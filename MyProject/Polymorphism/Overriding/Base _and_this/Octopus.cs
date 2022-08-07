using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Polymorphism.Overriding.Base__and_this
{
    class Octopus : Fish
    {
        int leg;

        public override void Swimming(int leg)
        {
            base.Swimming(leg);
            this.leg = leg;
            Console.WriteLine($"'Octopus' can swim and 'Octopus' have {this.leg} legs");
        }

    }
}
