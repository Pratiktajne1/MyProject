using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_8
{
    class Engine
    {
        int engineid;
        string lastenginecleandate;
        Subgare sub;
        public Engine(int engineid, string lastenginecleandate, Subgare sub)
        {
            this.engineid = engineid;
            this.lastenginecleandate = lastenginecleandate;
            this.sub = sub;
        }
        public void showengine()
        {
            Console.WriteLine(engineid + " " + lastenginecleandate);
            sub.showsub();
        }

    }
}
