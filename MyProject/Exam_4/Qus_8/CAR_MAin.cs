using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_8
{
    class CAR_MAin
    {
        static void Main(string[] args)
        {
            CAR c = new CAR(123, "white", new Engine(111, "08/2/2022", new Subgare("petrol")), new Gare("auto"));
            c.showcar();
            Console.ReadLine();
        }
    }
}
