using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram_in_opps
{
    class Animal
    {
        public string Name_of_animal;
        public int No_of_leg;
        public string Food_type;
        static void Main(string[] args)
        {
            Animal am = new Animal();
            am.Name_of_animal = "dog";
            am.No_of_leg = 4;
            am.Food_type = "Veg and non-Veg both";

            Console.WriteLine($"{am.Name_of_animal} ... {am.No_of_leg} ... {am.Food_type} ...");

            Animal a = new Animal();
            a.Name_of_animal = "Tiger";
            a.No_of_leg = 4;
            a.Food_type = "non-Veg";

            Console.WriteLine($"{a.Name_of_animal} ... {a.No_of_leg} ... {a.Food_type} ...");
        }
    }
}
