using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Prime_Method
{
    class Prime_or_Not
    {

        public bool PrimeA(int num)
        {
            bool a = true;
            for(int i =2; i<num; i++)
            {
                if (num % i == 0)
                {
                    a = false;
                    break;
                }
            }
            return a;
 
        }
    }
}
