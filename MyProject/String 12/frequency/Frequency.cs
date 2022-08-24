using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.frequency
{
    class Frequency
    {
        public void Display(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int d = 1;
                bool flag = true;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[k] == a[i])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag )
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            d++;
                        }
                    }
                    Console.WriteLine(a[i] + " frequency is " + d);

                }
            }

        }
    }
}
