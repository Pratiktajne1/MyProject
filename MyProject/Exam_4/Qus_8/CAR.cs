using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Exam_4.Qus_8
{
    class CAR
    {
        int carId;
        string carcolour;
        Engine engine;
        Gare gear;

        public CAR(int carId, string carcolour, Engine engine, Gare gear)
        {
            this.carId = carId;
            this.carcolour = carcolour;
            this.engine = engine;
            this.gear = gear;
        }
        public void showcar()
        {
            Console.WriteLine(carId + " " + carcolour);
            engine.showengine();
            gear.showgear();
        }
    }
}
