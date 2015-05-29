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

    }
}
