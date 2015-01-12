using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    interface IBatteryModel
    {
        int getEstimatedFlightTime();
        int getEstimatedFlightTime(int currentSecond);
        int getMaximumFlightTime();
        int getCurrentFlightTime();
    }
}
