using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ArrayProgram._2D_ARRAY.Sparse
{
    class Sparse
    {
        public bool Display(int[,] a)
        {
            bool flag = true;
            int n = 0;
            int v = 0;
            for(int i =0;i<a.GetLength(0);i++)
            { 
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(a[i,j]==0)
                    {
                        n++;
                    }
                    else
                    {
                        v++;
                    }
                }
            }
            if(n>v)
            {
                flag = false;
                return flag;
            }
            else
            {
                return flag;
            }
        }
    }
}
