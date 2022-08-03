using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Vowel
    {
        static void Main(string[] args)
        {
            char s;
            Console.WriteLine("Enter any char");
            s = Convert.ToChar(Console.ReadLine());

            if (s =='a')
            {
                Console.WriteLine("Vowel");
            }
            else if(s=='A')
            {
                Console.WriteLine("Vowel");
            }
            else if(s=='E')
            {
                Console.WriteLine("Vowel");
            }
            else if(s=='e')
            {
                Console.WriteLine("Vowel");
            }
            else if(s=='i')
            {
                Console.WriteLine("Vowel");
            }
            else if(s=='I')
            {
                Console.WriteLine("Vowel");
            }
            else if(s=='o')
            {
                Console.WriteLine("Vowel");
            }
            else if(s=='O')
            {
                Console.WriteLine("Vowel");
            }
            else if(s=='u')
            { 
                Console.WriteLine("Vowel"); 
            }
            else if(s=='U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("consonants");
            }
        }
    }
}
