using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Even_Odd_Sep
{
    class Main_Even_odd_SEp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("eenter array");
            int[] ar = new int[a];
            for(int i=0;i<a;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Even_ODD_SEp EOS = new Even_ODD_SEp();
            EOS.Display(ar);
        }
    }
}
