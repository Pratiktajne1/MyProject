using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop1
    {
        static void Main(string[] args)
        {
            int h;
            Console.WriteLine("enter any number for table");
            h = int.Parse(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(h + " x " + i + " = " + h * i);
            }



        }
    }
}
