using GMap.NET;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class GISUtils
    {
        public static RectLatLng getPolyMinMax(List<PointLatLngAlt> positions)
        {
            if (positions.Count == 0)
                return new RectLatLng();

            double minx, miny, maxx, maxy;

            minx = maxx = positions[0].Lng;
            miny = maxy = positions[0].Lat;

            foreach (PointLatLngAlt pnt in positions)
            {
                minx = Math.Min(minx, pnt.Lng);
                maxx = Math.Max(maxx, pnt.Lng);

                miny = Math.Min(miny, pnt.Lat);
                maxy = Math.Max(maxy, pnt.Lat);
            }

            return new RectLatLng(minx, maxy, miny - maxy, minx - maxx);
        }

        public double distance(PointLatLng p1, PointLatLng p2)
        {
            double theta = p1.Lng - p2.Lng;
            double dist = Math.Sin(deg2rad(p1.Lat)) * Math.Sin(deg2rad(p2.Lat)) + Math.Cos(deg2rad(p1.Lat)) * Math.Cos(deg2rad(p2.Lat)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515 * 1.609344;
                        
            return (dist);
        }

        private double rad2deg(double rad) {
	      return (rad / Math.PI * 180.0);
	    }

        private double deg2rad(double deg) {
	      return (deg * Math.PI / 180.0);
	    }

        public static utmpos addDistance(utmpos point, double bearing, double distance)
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
