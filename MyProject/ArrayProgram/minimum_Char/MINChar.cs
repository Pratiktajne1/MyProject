using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.minimum_Char
{
    class MINChar
    {
        public char Display_min_char(char[] a)
        {
            char c = a[0];
            for(int i=1;i<a.Length;i++)
            {
                if(c>a[i])
                {
                    c = a[i];
                }           
            }
            return c;
        }      
    }
}
