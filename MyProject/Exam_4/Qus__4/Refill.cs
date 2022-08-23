using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus__4
{
    class Refill
    {
        string inkColour;
        int Length;
        Nib nib;
        public string InkColour
        {
            get { return inkColour; }
            set { inkColour = value; }
        }
        public int length
        {
            get { return Length; }
            set { Length = value; }
        }
        public Nib Nibtype
        {
            get { return nib; }
            set { nib = value; }
        }
        
    }
}
