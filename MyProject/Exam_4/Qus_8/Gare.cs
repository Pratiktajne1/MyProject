using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_8
{
    class Gare
    {
        string type;
        public Gare(string type)
        {
            this.type = type;
        }
        public void showgear()
        {
            Console.WriteLine(type);
        }
    }
}
