using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram
{
    class CharArray_revers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter char");
            char[] ch = new char[5];
            for(int i=0;i<ch.Length;i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Revers char");
            for(int i =ch.Length-1;i>=0;i--)
            {
                Console.Write(ch[i] + "   ");
            }
        }
    }
}
