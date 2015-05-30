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

    }
}
