using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3.Qus_6
{
    class Shopping_2 : Shopping
    {
        public override void DoTransaction(string b)
        {
            if(b=="DebitCard")
            {
                Console.WriteLine("No discount");
            }
            else if(b == "CreditCard")
            {
                base.DoTransaction(b);
            }
            else
            {
                Console.WriteLine("enter valid option");
            }
        }
    }
}
