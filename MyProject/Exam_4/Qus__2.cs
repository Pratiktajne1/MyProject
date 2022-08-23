using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4
{
    class Qus__2
    {
            static int mcCartyCounter = 100;
            public static int mcCarthy(int n)
            {
                mcCartyCounter++;
                if (n > 100)
                    return n - 10;
                else
                    return mcCarthy(n + 11);
            }
            public static void Main(string[] args)
            {
                Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
                Console.ReadLine();

            }
        
    }
}
