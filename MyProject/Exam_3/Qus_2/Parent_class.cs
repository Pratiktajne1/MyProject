using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3.Qus_2
{
    class Parent_class
    {
        int family_member;
        protected string Sister_name;
        public Parent_class(int a)
        {
            this.family_member = a;
        }
        public void Family_member()
        {
            Console.WriteLine("Family member is :-" + family_member);
        }
    }
}
