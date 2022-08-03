using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.loop
{
    class Loop_9
    {
        static void Main(string[] args)
        {
            long num,i,sum=0,count_num = 0;
            Console.WriteLine("Enter any number");
            num = long.Parse(Console.ReadLine());
 
            while(num>0)
            {
                i = num % 10;
                sum = sum + i;
                num = num / 10;
                count_num++;
            }
            Console.WriteLine($"number count is = {count_num} and number count avg is = {(sum/count_num)}");


        }                                                                                    
    }
}
