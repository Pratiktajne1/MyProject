using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Hierarchical_type
{
    class Song
    {
        protected int size;
        
        public void Show(int a)
        {
            size = a;
            Console.WriteLine("Song Size => " + size);
        }
    }
}
