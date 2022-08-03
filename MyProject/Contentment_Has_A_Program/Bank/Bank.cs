using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Bank
{
    class Bank
    {
        string brand;
        int price;
        string color;
        Pen p;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public Pen P
        {
            get
            {
                return p;
            }
            set
            {
                p = value;
            }
        }

    }
}
