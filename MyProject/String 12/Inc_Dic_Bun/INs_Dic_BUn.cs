using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.Inc_Dic_Bun
{
    class INs_Dic_BUn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int s = 0, f = 0, c = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            string S = a.ToString();
            for (int i = 0; i < S.Length - 1; i++)
            {
                s++;
                if ((int)S[i] > (int)S[i + 1])
                {
                    f++;
                }
                if ((int)S[i] < (int)S[i + 1])
                {
                    c++;
                }
            }
            if (s == f)
            {
                Console.WriteLine("dic");
            }
            if (s == c)
            {
                Console.WriteLine("inc");
            }
            if (s != c && s != f)
            {
                Console.WriteLine("Bun");
            }
        }
    }
}
