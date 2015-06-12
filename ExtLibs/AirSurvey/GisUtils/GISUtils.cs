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

        const float rad2deg1 = (float)(180 / Math.PI);
        const float deg2rad1 = (float)(1.0 / rad2deg1);

        public struct LineLatLng
        {
            public utmpos p1;
            public utmpos p2;
            public utmpos basepnt;
        }

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

        public static void newpos(ref double x, ref double y, double bearing, double distance)
        {
            double degN = 90 - bearing;
            if (degN < 0)
                degN += 360;
            x = x + distance * Math.Cos(degN * deg2rad1);
            y = y + distance * Math.Sin(degN * deg2rad1);
        }

        public static utmpos newpos(utmpos input, double bearing, double distance)
        {
            double degN = 90 - bearing;
            if (degN < 0)
                degN += 360;
            double x = input.x + distance * Math.Cos(degN * deg2rad1);
            double y = input.y + distance * Math.Sin(degN * deg2rad1);

            return new utmpos(x, y, input.zone);
        }

        public static LineLatLng findClosestLine(utmpos start, List<LineLatLng> list)
        {
            LineLatLng answer = list[0];
            double shortest = double.MaxValue;

            foreach (LineLatLng line in list)
            {
                double ans1 = start.GetDistance(line.p1);
                double ans2 = start.GetDistance(line.p2);
                utmpos shorterpnt = ans1 < ans2 ? line.p1 : line.p2;

                if (shortest > start.GetDistance(shorterpnt))
                {
                    answer = line;
                    shortest = start.GetDistance(shorterpnt);
                }
            }

            return answer;
        }

        public static utmpos FindLineIntersection(utmpos start1, utmpos end1, utmpos start2, utmpos end2)
        {
            double denom = ((end1.x - start1.x) * (end2.y - start2.y)) - ((end1.y - start1.y) * (end2.x - start2.x));
            //  AB & CD are parallel         
            if (denom == 0)
                return utmpos.Zero;
            double numer = ((start1.y - start2.y) * (end2.x - start2.x)) - ((start1.x - start2.x) * (end2.y - start2.y));
            double r = numer / denom;
            double numer2 = ((start1.y - start2.y) * (end1.x - start1.x)) - ((start1.x - start2.x) * (end1.y - start1.y));
            double s = numer2 / denom;
            if ((r < 0 || r > 1) || (s < 0 || s > 1))
                return utmpos.Zero;
            // Find intersection point      
            utmpos result = new utmpos();
            result.x = start1.x + (r * (end1.x - start1.x));
            result.y = start1.y + (r * (end1.y - start1.y));
            result.zone = start1.zone;
            return result;
        }

        public static utmpos findClosestPoint(utmpos start, List<utmpos> list)
        {
            utmpos answer = utmpos.Zero;
            double currentbest = double.MaxValue;

            foreach (utmpos pnt in list)
            {
                double dist1 = start.GetDistance(pnt);

                if (dist1 < currentbest)
                {
                    answer = pnt;
                    currentbest = dist1;
                }
            }

            return answer;
        }


    }
}
