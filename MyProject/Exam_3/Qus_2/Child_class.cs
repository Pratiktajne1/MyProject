using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3.Qus_2
{
    class Child_class : Parent_class
    {
        public Child_class(int a,string b): base(a)
        {
            base.Family_member();
            base.Sister_name = b;
            this.Sister();
        }
        public void Sister()
        {
            Console.WriteLine("Sister name is :- " + base.Sister_name);
        }
    }
}
