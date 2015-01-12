using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class LinearBatteryModelImpl : IBatteryModel
    {
        int _currentFlightTime = 0;
        int _maximumFlightTime = 900; // 15 minutes

        public int getEstimatedFlightTime()
        {
            return _maximumFlightTime - _currentFlightTime;   
        }

        public int getEstimatedFlightTime(int currentSecond)
        {
            return _maximumFlightTime - currentSecond;
        }

        public int getMaximumFlightTime()
        {
            return _maximumFlightTime;
        }

        public int getCurrentFlightTime()
        {
            return _currentFlightTime;
        }
    }
}
