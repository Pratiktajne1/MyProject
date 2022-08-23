using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Password
{
    class Password
    {
        public void Display(string s)
        {
            int f=0,b=0,c=0,d=0;
            foreach(char a in s)
            {
                if (char.IsLower(a))
                {
                    f++;
                }
                else if (char.IsUpper(a))
                {
                    b++;
                }
                else if (char.IsDigit(a))
                {
                    c++;
                }
                else if (!Char.IsLetterOrDigit(a))
                {
                    d++;
                }
            }
            if (s.Length>7)
            {
                if (f>0 && b>0 && c>0 && d>0)
                {
                    Console.WriteLine("password is correct ");
                }
                else
                {
                    Console.WriteLine("use digit symbol and upper, lower alphabets");
                }
            }
            else
            {
                Console.WriteLine("length should be more than 7");
            }
        }
    }
}
