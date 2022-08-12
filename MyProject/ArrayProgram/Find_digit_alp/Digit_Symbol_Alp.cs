using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Find_digit_alp
{
    class Digit_Symbol_Alp
    {
        public void Display(char[] aa)
        {
            int s = 0, b = 0, c = 0,D=0;
            for(int i=0;i<aa.Length;i++)
            {
                if( aa[i]>=65 && aa[i]<=90)
                {
                    Console.WriteLine(aa[i] + " is Capital Alphabet");
                    s++;
                }
                else if(aa[i]>=96 && aa[i]<=122)
                {
                    Console.WriteLine($"{aa[i]} is smaller Alphabet ");
                    b++;
                }
                else if(aa[i]>=48 && aa[i]<=57)
                {
                    Console.WriteLine(aa[i] + " is digit");
                    c++;
                }
                else
                {
                    Console.WriteLine(aa[i] + " is symbol ");
                    D++;
                }
            }
            Console.WriteLine("------Total Capital Alphabet is ==> "+s);
            Console.WriteLine("------Total Smaller Alphabet is ==> " + b);
            Console.WriteLine("------Total Digit is ==> " + c);
            Console.WriteLine("------Total Special Symbol is ==> " + D);
        }
    }
}
