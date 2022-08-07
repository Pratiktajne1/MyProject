using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Program_ex
{
    class Qus_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");

            int num = int.Parse(Console.ReadLine());
            int j = 1;
            
            for(int i =1; i<num; i++)
            {

                j = (j + j);
                int r = j + 1;
                Console.Write(r + " ");

            }
        }

    }
}
