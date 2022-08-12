using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3.Qus_6
{
    class Main_Shopping
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CreditCard\nDebitCard\nenter transaction type");
            string s = Console.ReadLine();
            Shopping_2 shopping_2 = new Shopping_2();
            shopping_2.DoTransaction(s);
        }
    }
}
