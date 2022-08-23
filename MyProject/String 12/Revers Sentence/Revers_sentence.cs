using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Revers_Sentence
{
    class Revers_sentence
    {
        public string Revers(string s)
        {
           
            string a = "";
            for(int i=s.Length-1;i>=0;i--)
            {
                a = a + s[i];
            }
            return a;
        }
    }
}
