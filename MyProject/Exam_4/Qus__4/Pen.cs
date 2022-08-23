using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus__4
{
    class Pen
    {
        Refill refill;
        string brand;
        int caplength;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public Refill Refills
        {
            get { return refill; }
            set { refill = value; }
        }
       
    }
}
