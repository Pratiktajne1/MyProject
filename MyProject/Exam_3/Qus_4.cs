using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_3
{
    class Qus_4
    {
        static void Main(string[] args)
        {
            for(int i =1; i<=4;i++)
            {
                int j = 1;
                for(int k =1;k<=7;k++)
                {
                    if(k>=5-i && k<=3+i)
                    {
                        Console.Write(j);
                        j++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
