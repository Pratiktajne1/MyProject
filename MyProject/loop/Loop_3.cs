using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_3
    {
        static void Main(string[] args)
        {
            int s = 0;
            for(int i=1;i<=10;i++)
            {
                s = s + i;
            }
            Console.WriteLine("addition is :- " + s);
        }
    }
}
