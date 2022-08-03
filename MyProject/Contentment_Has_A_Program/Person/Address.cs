using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Contentment_Has_A_Program.Person
{
    class Address
    {
        int pincode;
        string city;

        public int Pincode
        {
            set { pincode = value; }
            get { return pincode; }
        }
        public string City
        {
            set;
            get;
        }
    }
}
