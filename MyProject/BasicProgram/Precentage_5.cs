using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Precentage_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any 5 subject (less than 101)");
            float s1, s2, s3, s4, s5,result;

            s1 = float.Parse(Console.ReadLine());
            s2 = float.Parse(Console.ReadLine());
            s3 = float.Parse(Console.ReadLine());
            s4 = float.Parse(Console.ReadLine());
            s5 = float.Parse(Console.ReadLine());

            result = (s1 + s2 + s3 + s4 + s5) / 5;

            if(result>70)
            {
                Console.WriteLine("distension");
            }
            else if(result>60 && result<=70)
            {
                Console.WriteLine("first Class");
            }
            else if(result>50 && result<=60)
            {
                Console.WriteLine("second class");
            }
            else if(result>34 && result <=50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("fail");
            }

        }
    }
}
