using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Program_ex
{
    class SumofEveen
    {
        static void Main(string[] args)
        {/*
            int sum = 0;
            for(int i = 1; i<=20; i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;

                }
            }
            Console.WriteLine("  sum is = " + sum);*/




            /*while(true)
            {
                bool flag = true;
                int num = int.Parse(Console.ReadLine());
                int r = 0;
                while(num>0)
                {
                    r = num % 10;
                    if(r==0)
                    {
                        flag = false;
                        break;
                    }
                    num = num / 10;
                }
                if(flag==false)
                {
                    break;
                }
            }*/



            int n = 0;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if(num<0)
                {
                    n = n + num;
                }
                else if(num>0)
                {
                    Console.WriteLine("  " + num);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("sum :- " + n);
        }
    }
}
