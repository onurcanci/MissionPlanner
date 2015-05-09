using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    interface IBatteryModel
    {
        String getName();
        int getEstimatedFlightTime();
        int getEstimatedFlightTime(int currentSecond);
        int getMaximumFlightTime();
        int getCurrentFlightTime();

        void tick();
    }
}
