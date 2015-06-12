using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace AirSurvey
{
    class RouteStat
    {
        public double FlightTime = 0;
        public double FlightDistance = 0;
        public RouteStat(RouteUtil2 route2, int maximumSpeedNm)
        {
            GMapRoute r = new GMapRoute("route");
            route2.RoutePoints.ForEach(wp =>
            {
                r.Points.Add(wp);
            });

            FlightDistance = r.Distance;
            FlightTime = ((r.Distance * 1000.0) / ((maximumSpeedNm * 0.8)));
        }
    }
}
