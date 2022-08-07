using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritance.Hierarchical_type
{
    class English : Song
    {
        string Song_name;
        string Song_type;
        string Singer_name;

        public void Display(string a,string b,string c)
        {
            Song_name = a;
            Song_type = b;
            Singer_name = c;

            Console.WriteLine($"Singer name => {Singer_name} \nSong Name => {Song_name}" +
                $"\nSong Type = {Song_type}");
        }


    }
}
