using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Tuple_Demo.Method_1
{
    class Method__1_Main
    {
        static void Main(string[] args)
        {
            Method__1 M_1 = new Method__1();
            Tuple<int ,int> t = M_1.Display(12, 34);

            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);
        }
    }
}
