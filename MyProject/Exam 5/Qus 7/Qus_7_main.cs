using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_5.Qus_7
{
    class Qus_7_main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array");
   
            int[][] s= new int[3][];
            s[0] = new int[4];
            s[1] = new int[5];
            s[2] = new int[3];

            for(int i=0;i<s.GetLength(0);i++)
            {
                for(int j=0;j<s[i].Length;j++)
                {
                    s[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Qus_7 Q = new Qus_7();
            Q.Display(s);

        }
    }
}
