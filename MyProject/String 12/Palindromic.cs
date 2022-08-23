using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12
{
    class Palindromic
    {
        public string Torevers(string a)
        {
            string s = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                s =s+ a[i];

            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Palindromic p = new Palindromic();
            string d=p.Torevers(s);
            if(d==s)
            {
                Console.WriteLine("Palindromic");
            }
            else
            {
                Console.WriteLine("not Palindromic");
            }
            
            



        }
    }
}
