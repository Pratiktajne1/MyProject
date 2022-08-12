using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Even_index_element
{
    class Even_element_position_Main
    {
        static void Main(string[] args)
        {
            Even_element_position E = new Even_element_position();
            Console.WriteLine("enter size");
            int a = int.Parse(Console.ReadLine());

            int[] arr = new int[a];
            Console.WriteLine("enter value");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            E.Display(arr);
        }
    }
}
