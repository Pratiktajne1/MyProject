using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Remove_duplicate
{
    class Remove_Duplicate
    {
        public void Display(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                bool flag = true;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[k] == a[i])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.Write(a[i]);
                }
            }
        }
    }
}

