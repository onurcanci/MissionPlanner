using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class DummyBatteryModel : IBatteryModel
    {
        int maximumFlightTime = 0;
        int currentFlightTime = 0;

        public string getName()
        {
            return "Dummy Battery Model";
        }

        public int getEstimatedFlightTime()
        {
            return Math.Abs(new Random().Next()) % 50;
        }

        public int getEstimatedFlightTime(int currentSecond)
        {
            return getEstimatedFlightTime() - currentSecond;
        }

        public int getMaximumFlightTime()
        {
            return getEstimatedFlightTime();
        }

        public int getCurrentFlightTime()
        {
            return currentFlightTime;
        }
    

        public void tick()
        {
 	        currentFlightTime++;
        }
    }
}
