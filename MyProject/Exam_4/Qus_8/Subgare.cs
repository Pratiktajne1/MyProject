using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_8
{
    class Subgare
    {
        string subenginetype;
        public Subgare(string subenginetype)
        {
            this.subenginetype = subenginetype;
        }
        public void showsub()
        {
            Console.WriteLine(subenginetype);
        }
    }
}
