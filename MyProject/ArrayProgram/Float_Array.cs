using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram
{
    class Float_Array
    {
        static void Main(string[] args)
        {
            float[] ar = new float[5];
            Console.WriteLine("enter value");
            for(int i=0; i<5;i++)
            {
                ar[i] = float.Parse(Console.ReadLine());
            }
            foreach(float x in ar)
            {
                Console.Write("  " + x);
            }
            Console.WriteLine(" "+string.Join("  " , ar));

            
        }
    }
}
