using System;

namespace MyProject
{
    class Program_1
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());

            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            
            if(a>=b && a>=c )
            {
                Console.WriteLine(a);
            }
            else if(b>=a && b>=c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
