using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.String_12.EMail
{
    class EMail
    {
        public void Display(string a)
        {
            int w = 0,b = 0;
            foreach(char c in a)
            {
                if(c=='@')
                {
                    w++;
                }
                if(c=='.')
                {
                    b++;
                }            
            }
            if(b==1 && w==1)
            {
                if(a.IndexOf('@')<a.IndexOf('.'))
                {
                    int f = 1 + a.IndexOf('@');
                    int h = 1 + a.IndexOf('.');
                    string p = a.Substring(h);
                    string g = a.Substring(f, 5);
                    if(g=="gmail" && p=="com")
                    {
                        Console.WriteLine("Correct Emaild");
                    }
                    else
                    {
                        Console.WriteLine("====>> ( gmail or com not write )");
                    }
                }
                else
                {
                    Console.WriteLine("====>> ( . use before @ )");
                }
            }
            else
            {
                Console.WriteLine("====>> ( more than 1 @ or . is there )");
            }

        }
    }
}
