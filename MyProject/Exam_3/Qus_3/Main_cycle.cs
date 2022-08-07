using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3.Qus_3
{
    class Main_cycle
    {
        static void Main(string[] args)
        {
            int a=2, b=1;
            Motorcycle motorcycle = new Motorcycle(a, b);
            motorcycle.TyreAndWheels();
            motorcycle.Engine();
        }
    }
}
