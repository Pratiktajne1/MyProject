using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Switch
{
    class Switch_odd_or_even
    {
        static void Main(string[] args)
        {
            /*
                        Console.WriteLine("enter any number");
                        int a = int.Parse(Console.ReadLine());

                        switch(a%2)                                         //method 1
                        {
                            case 0:
                                Console.WriteLine(a + " this is even no");
                                break;
                            default:
                                Console.WriteLine($"{a} is odd no");
                                break;
                        }

            */
            Console.WriteLine("enter any number");
            int a = int.Parse(Console.ReadLine());

            switch (a % 2==0)                                         //method 2
            {
                case true:
                    Console.WriteLine(a + " this is even no");
                    break;
                default:
                    Console.WriteLine($"{a} is odd no");
                    break;
            }



        }
    }
}
