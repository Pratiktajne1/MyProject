using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3.Qus_6
{
    class Shopping
    {
        public virtual void DoTransaction(string b)
        {
            if(b =="CreditCard")
            {
                Console.WriteLine("You got 15% ");
            }
        }
    }
}
