using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Revers_Sentence
{
    class Revers_sentence_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Revers_sentence Rs = new Revers_sentence();
            string[] r = s.Split(" ");
            foreach(string c in r)
            {
                string d = Rs.Revers(c);
                Console.Write(d + " ");
            }

        }
    }
}
