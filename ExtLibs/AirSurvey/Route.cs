using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class Route
    {
        public List<InternalWayPoint> WayPoints = new List<InternalWayPoint>();
        public float cost = 0f;
        public int depth = 0;

        public Route clone()
        {
            Route clone = new Route();
            WayPoints.ForEach(x => { clone.WayPoints.Add(x); });
            clone.cost = cost;

            return clone;
        }

        public void increaseDepth()
        {
            depth++;
        }

    }
}
