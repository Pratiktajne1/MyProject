using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Program_ex
{
    class Qus_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());

            int r = 1,j=1;

            for(int i=1; i<=num; i++)
            {
                
                Console.Write(j + " ");
                r = r + r;

                j = r + j;
            }
        }
    }
}
