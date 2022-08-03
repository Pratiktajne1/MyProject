using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_7
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 15)
            {
                if (i % 3 == 0 && i % 9 == 0)
                {
                    Console.WriteLine(i);
                   
                }
                i++;
            }

        }
    }
}