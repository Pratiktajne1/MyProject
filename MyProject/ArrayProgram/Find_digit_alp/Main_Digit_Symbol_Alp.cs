using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Find_digit_alp
{
    class Main_Digit_Symbol_Alp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number for Array Size");
            int a = int.Parse(Console.ReadLine());
            char[] ar = new char[a];
            Console.WriteLine("Enter array");
            for(int i =0; i<a;i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Digit_Symbol_Alp DSA = new Digit_Symbol_Alp();
            DSA.Display(ar);
        }
    }
}
