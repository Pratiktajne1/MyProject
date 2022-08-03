using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Bank
{
    class Pen
    {
        int length;
        string name;
        string color;
        string type;

        public int Length
        {
            set;
            get;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Color
        {
            set { color = value; }
            get { return color; }
        }
        public string Type
        {
            set { type = value; }
            get { return type; }
        }

    }
}
