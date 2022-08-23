using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Name
{
    class Name_1
    {
        public void Display(string a)
        {
            bool flag = false;
            for(int i=0;i<a.Length;i++)
            {
                if((char.IsDigit(a[i])) || (char.IsSymbol(a[i])))
                {
                    flag = true;
                    Console.WriteLine("remove symbol and digit");
                    break;
                }             
            }
            if(flag==false)
            {
                Console.WriteLine("correct name");
            }
        }
    }
}
