using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Qus_2
{
    class Qus_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            int sa = 0;
            int d = 0;
            for(int i=s.Length-1;i>=0;i--)
            {
                if (s[i] == 'a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u')
                {
                    sa++;
                }
                else
                {
                    d++;
                }
                Console.Write("   " + s[i]);
            }
            Console.WriteLine("consonant =   " + d);
            Console.WriteLine("vowel  =   " + sa);

        }
           
    }
}
