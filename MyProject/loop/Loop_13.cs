using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any char");
            char b = Convert.ToChar(Console.ReadLine());
            char a;
            for( a=b ; a>='A';a--)
            {
                for(char j='A'; j<=a;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
