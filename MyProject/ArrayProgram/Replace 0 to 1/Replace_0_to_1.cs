using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.Replace_0_to_1
{
    class Replace_0_to_1
    {
        public Replace_0_to_1(int[] ar)
        {
            for(int i=0;i<ar.Length;i++)
            {
                if(ar[i]==0)
                {
                    ar[i] = 1;
                }
            }
            for(int i=0;i<ar.Length;i++)
            {
                Console.Write("    " + ar[i]);
            }
        }
    }
}
