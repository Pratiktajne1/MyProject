using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram.count_occurrence
{
    class Count_Occurrence
    {
        public void Display(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                bool flag = true;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        flag = false;
                        break;
                    }
                    if(flag==true)
                    {
                        for(int j=i+1;j<a.Length;j++)
                        {

                        }
                    }
                }
            }
        }
    }
}
