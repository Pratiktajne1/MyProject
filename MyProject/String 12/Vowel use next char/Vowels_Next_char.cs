using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Vowel_use_next_char
{
    class Vowels_Next_char
    {
        public void Display(string s)
        {
            s = s.Replace('a', 'b');
            s = s.Replace('e', 'f');
            s = s.Replace('i', 'j');
            s = s.Replace('o', 'p');
            s = s.Replace('u', 'v');
            s = s.Replace('A', 'B');
            s = s.Replace('E', 'F');
            s = s.Replace('I', 'J');
            s = s.Replace('O', 'P');
            s = s.Replace('U', 'V');

            Console.WriteLine(s);

        }
    }
}
