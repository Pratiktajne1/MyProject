using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Word_move
{
    class Word_Move
    {
        public void Display(string s, int a)
        {
            int f;
            string h = "";
            char d;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < 'V')
                {
                    f = (int)s[i] + a;
                    d = (char)f;
                    h = h + d;
                }
                else if (s[i] >= 'V' && s[i] <= 'Z')
                {
                    f = (int)s[i] + a;
                    f = f - 90;
                    f = f + 65;
                    d = (char)f;
                    h = h + d;
                }
                if (s[i] < 'v')
                {
                    f = (int)s[i] + a;
                    d = (char)f;
                    h = h + d;
                }
                else if (s[i] >= 'v' && s[i] <= 'z')
                {
                    f = (int)s[i] + a;
                    f = f - 122;
                    f = f + 97;
                    d = (char)f;
                    h = h + d;
                }


            }
            Console.WriteLine(h);
        }
    }
}