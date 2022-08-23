using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_13
{
    class Qus_13
    {
        public void Display()
        {
            int a = 0, b = 0, c = 0;
            for(int i=0;i<=50;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("buzzfizz");
                    a++;
                }
                else if(i%3==0)
                {
                    b++;
                    Console.WriteLine("buzz");
                }
                else if(i%5==0)
                {
                    c++;
                    Console.WriteLine("fizz");
                }
            }
            Console.WriteLine("buzzfizz == "+a);
            Console.WriteLine("buzz == "+b);
            Console.WriteLine("fizz == "+c); 
        }

        

    }
}
