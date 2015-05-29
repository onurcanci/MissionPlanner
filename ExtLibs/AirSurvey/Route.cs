using GMap.NET;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class Route
    {
        private List<PointLatLngAlt> _polygon= new List<PointLatLngAlt>();
        private List<utmpos> utmpositions;

        public List<utmpos> gridPoints = new List<utmpos>();
        
        private List<InternalWayPoint> _waypoints = new List<InternalWayPoint>();
        public List<InternalWayPoint> WayPoints
        {
            get
            {
                return _waypoints;
            }
        }

        private int zone;

        public RectLatLng OuterPolygon { 
            get{
                return GISUtils.getPolyMinMax(_polygon);
            }
        }        

        public Route(List<PointLatLng> polygon)
        {
            polygon.ForEach(x =>
            {
                _polygon.Add(new PointLatLngAlt(x));
            });

            zone = _polygon[0].GetUTMZone();
            utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(zone,_polygon), zone);
        }

        public void calculate(FieldOfView fov)
        {
            gridPoints.Clear();
            PointLatLngAlt leftTop = new PointLatLngAlt(OuterPolygon.Left, OuterPolygon.Top);
            PointLatLngAlt rightBottom = new PointLatLngAlt(OuterPolygon.Right, OuterPolygon.Bottom);

            int rowIdx = 0;

            while (leftTop.Lat > rightBottom.Lat)
            {
                utmpos current = new utmpos(leftTop);
                utmpos next = addDistance(addDistance(current, 90, fov.width / 2), 180, fov.height / 2);
                int columnIdx = 0;

                while (next.ToLLA().Lng < rightBottom.Lng)
                {
                    _waypoints.Add(new InternalWayPoint(next,columnIdx,rowIdx));
                    gridPoints.Add(next);
                    next = addDistance(next, 90, fov.width);
                    columnIdx++;
                }
                leftTop = addDistance(new utmpos(leftTop), 180, fov.height);
                rowIdx++;
            }

        }

        private static utmpos addDistance(utmpos point, double bearing, double distance)
        {
            double degN = 90 - bearing;
            if (degN < 0)
                degN += 360;
            utmpos newPosition = new utmpos(point);

            newPosition.x = point.x + distance * Math.Cos(degN * Constants.deg2rad);
            newPosition.y = point.y + distance * Math.Sin(degN * Constants.deg2rad);

            return newPosition;
        }


    }
}
