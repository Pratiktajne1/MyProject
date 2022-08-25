using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Tuple_Demo.Method_1
{
    class Method__1
    {
        public Tuple<int,int> Display(int a, int b)
        {
            int sum = a + b;
            int pro = a * b;
            return Tuple.Create<int,int>(sum,pro);
        }
    }
}
