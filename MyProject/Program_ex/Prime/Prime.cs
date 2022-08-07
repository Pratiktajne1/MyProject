using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Program_ex.Prime
{
    class Prime
    {
        int num;
        public void Prime_1()
        {
            while(true)
            {
                int a = 10;
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("number is negative");
                    break;
                }
                for(int i=2; i<num; i++)                   
                {
                    if (num % i == 0)
                    {
                        a = 1;               
                        break;
                    }
                }
                if(a==10)
                {
                    Console.WriteLine("  "+num);
                }
            }
          
        }
    }
}
