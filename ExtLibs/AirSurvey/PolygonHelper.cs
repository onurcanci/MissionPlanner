using GMap.NET;
using GMap.NET.WindowsForms;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    public static class PolygonHelper
    {

        public static double calculateMainAngle(List<PointLatLngAlt> polygon)
        {
            if (polygon.Count == 0)
                return 0;
            double angle = 0;
            double maxdist = 0;
            PointLatLngAlt last = polygon[polygon.Count - 1];
            foreach (var item in polygon)
            {
                if (item.GetDistance(last) > maxdist)
                {
                    angle = item.GetBearing(last);
                    maxdist = item.GetDistance(last);
                }
                last = item;
            }

            return (angle + 360) % 360;
        }

        public static double calculateAngle(List<PointLatLngAlt> polygon)
        {
            RectLatLng outerPoly = PolygonHelper.getPolyMinMax(polygon);

            double topLat = 0;
            double topLng = 0;
            int top = 0;

            double bottomLat = 0;
            double bottomLng = 0;
            int bottom = 0;


            polygon.ForEach(x =>
            {
                if (x.Lat > outerPoly.LocationMiddle.Lng)
                {
                    top++;
                    topLat += x.Lat;
                    topLng += x.Lng;
                }
                else
                {
                    bottom++;
                    bottomLat += x.Lat;
                    bottomLng += x.Lng;
                }
            });

            PointLatLngAlt topMiddle = new PointLatLngAlt(topLat/top,topLng/top);
            PointLatLngAlt bottomMiddle = new PointLatLngAlt(bottomLat/bottom, bottomLng/bottom);

            return topMiddle.GetBearing(bottomMiddle);
        }

        public static bool isPolygonsIntersect(List<PointLatLngAlt> polygon1, List<PointLatLngAlt> polygon2)
        {
            bool result = false;
            polygon2.ForEach(x =>
            {
                if (result == false && IsPointInPolygon(polygon1, x))
                {
                    result = true;
                }
            });

            if (!result)
            {
                polygon1.ForEach(x =>
                {
                    if (result == false && IsPointInPolygon(polygon2, x))
                    {
                        result = true;
                    }
                });
            }

            return result;
        }

        public static bool isPointInPolygon(List<utmpos> polygon, utmpos PointToDetermine)
        {
            if (polygon.Count < 3)
                return false;

            List<utmpos> localPointList = new List<utmpos>();
            localPointList.AddRange(polygon);
            localPointList.Add(polygon[0]);
            int counter = 0;
            int i;
            double xinters;
            utmpos p1, p2;

            p1 = polygon[0];
            for (i = 1; i < localPointList.Count; i++)
            {
                p2 = localPointList[i % localPointList.Count];

                if (PointToDetermine.y > Math.Min(p1.y, p2.y))
                {
                    if (PointToDetermine.y <= Math.Max(p1.y, p2.y))
                    {
                        if (PointToDetermine.x <= Math.Max(p1.x, p2.x))
                        {
                            if (p1.y != p2.y)
                            {
                                xinters = (PointToDetermine.y - p1.y) * (p2.x - p1.x) / (p2.y - p1.y) + p1.x;
                                if (p1.x == p2.x || PointToDetermine.x <= xinters)
                                    counter++;
                            }
                        }
                    }
                }
                p1 = p2;
            }

            if (counter % 2 == 0)
                return false;

            return true;
        }

        public static bool IsPointInPolygon(this List<PointLatLngAlt> polygon, PointLatLng PointToDetermine)
        {
            if (polygon.Count < 3)
                return false;

            List<PointLatLngAlt> localPointList = new List<PointLatLngAlt>();
            localPointList.AddRange(polygon);
            localPointList.Add(polygon[0]);
            int counter = 0;
            int i;
            double xinters;
            PointLatLng p1, p2;

            p1 = polygon[0];
            for (i = 1; i < localPointList.Count; i++)
            {
                p2 = localPointList[i % localPointList.Count];

                if (PointToDetermine.Lat > Math.Min(p1.Lat, p2.Lat))
                {
                    if (PointToDetermine.Lat <= Math.Max(p1.Lat, p2.Lat))
                    {
                        if (PointToDetermine.Lng <= Math.Max(p1.Lng, p2.Lng))
                        {
                            if (p1.Lat != p2.Lat)
                            {
                                xinters = (PointToDetermine.Lat - p1.Lat) * (p2.Lng - p1.Lng) / (p2.Lat - p1.Lat) + p1.Lng;
                                if (p1.Lng == p2.Lng || PointToDetermine.Lng <= xinters)
                                    counter++;
                            }
                        }
                    }
                }
                p1 = p2;
            }

            if (counter % 2 == 0)
                return false;

            return true;
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

        public static Rect getPolyMinMax(List<utmpos> utmpos)
        {
            if (utmpos.Count == 0)
                return new Rect();

            double minx, miny, maxx, maxy;

            minx = maxx = utmpos[0].x;
            miny = maxy = utmpos[0].y;

            foreach (utmpos pnt in utmpos)
            {
                minx = Math.Min(minx, pnt.x);
                maxx = Math.Max(maxx, pnt.x);

                miny = Math.Min(miny, pnt.y);
                maxy = Math.Max(maxy, pnt.y);
            }

            return new Rect(minx, maxy, maxx - minx, miny - maxy);
        }

        public static bool IsPointInPolygon(utmpos p, List<utmpos> poly)
        {
            utmpos p1, p2;
            bool inside = false;

            if (poly.Count < 3)
            {
                return inside;
            }
            utmpos oldPoint = new utmpos(poly[poly.Count - 1]);

            for (int i = 0; i < poly.Count; i++)
            {

                utmpos newPoint = new utmpos(poly[i]);

                if (newPoint.y > oldPoint.y)
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }
                else
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }

                if ((newPoint.y < p.y) == (p.y <= oldPoint.y)
                    && ((double)p.x - (double)p1.x) * (double)(p2.y - p1.y)
                    < ((double)p2.x - (double)p1.x) * (double)(p.y - p1.y))
                {
                    inside = !inside;
                }
                oldPoint = newPoint;
            }
            return inside;
        }

    }
}
