using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Encapsulation
{
    class Car
    {
        int module_no;
        string name;
        float price;
        int speed;

        public int Module_no
        {
            set
            {
                module_no = value;
            }
            get
            {
                return module_no;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public float Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
        public int Speed
        {
            set
            {
                speed = value;
            }
            get
            {
                return speed;
            }
        }
        
    }
}
