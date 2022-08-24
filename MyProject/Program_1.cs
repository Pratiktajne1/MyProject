using System;

namespace MyProject
{
    class Program_1
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int g = 0;
            for(int i=2;i<=a || i<=b;i++)
            {
                if(a%i==0 && b%i==0)
                {
                    
                    g++;
                }
            }
            if(g==0)
            {
                Console.WriteLine("coprime");
            }
            
          

        }
    }
}
