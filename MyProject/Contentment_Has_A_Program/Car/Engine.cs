using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Car
{
    class Engine
    {
        string type;

        public Engine(string type)
        {
            this.type = type;
        }
        public void Display()
        {
            Console.WriteLine("type = " + type);
        }
    }
}
