using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Program_ex
{
    class Binary_to_dight
    {
        static void Main(string[] args)
        {
            int r = 0, s = 0, k = 1; ;
            Console.WriteLine("enter any binary number");
            int num = int.Parse(Console.ReadLine());
            while(num>0)   //1010
            {
                r = num % 10; // 0
                if (r == 1 && s == 0)
                {
                    k = 1;
                }
                if (r==0)
                {
                    s++;
                    num = num / 10;    
                    continue;

                }
                
                for(int i =1; i<=s;i++) //s=1
                {
                   
                    k = k * 2;

                }
                s = s + k;
                num = num / 10;
            }
            Console.WriteLine("answer is = " + s);
           
        }
    }
}
