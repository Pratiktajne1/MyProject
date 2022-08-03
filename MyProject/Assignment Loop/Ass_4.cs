using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment_Loop
{
    class Ass_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any 2 number for LCM and GCM");
            int a, b,n=3;
            bool sd = true;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
               
                int num = i*a;
                for(int j=1; j<=num; j++)
                {
                    if(j*b >num)
                    {
                        break;
                    }
                    if(j*b==num)
                    {
                        Console.WriteLine("LCM is :- "+num);
                        sd = false;
                    }
                }
                if(sd==false)
                {
                    n = 0;
                    int d = (a * b) / num;
                    Console.WriteLine("GCM is :- " + d);
                }
                n++;
                
            }
            
         
               
        }
    }
}
