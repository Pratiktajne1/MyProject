using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Abstract_and_Interface.Qus_1
{
    class Child_of_Interface : IFacable
    {
      
        public void Display(int a)
        {
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of factor is = " + sum);
        }
    }
}
