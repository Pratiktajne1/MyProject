using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Vowel_use_next_char
{
    class Vowels_Next_char_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Vowels_Next_char V = new Vowels_Next_char();
            V.Display(s);
        }
    }
}
