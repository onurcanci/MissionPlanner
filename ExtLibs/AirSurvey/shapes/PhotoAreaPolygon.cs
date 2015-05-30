using GMap.NET;
using GMap.NET.WindowsForms;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey.Shapes
{
    class PhotoAreaPolygon : GMapPolygon
    {
        public PhotoAreaPolygon(InternalWayPoint center, double width, double height)
            : base(new List<PointLatLng>(), "PhotoFrameOverlay")
        {
            Fill = new SolidBrush(Color.FromArgb(center.active ? 20 : 0, Color.Blue));
            Stroke = new Pen(Color.Wheat, 1);
            Stroke.DashPattern = new float[] { 5, 5 };


            utmpos utmCenter = new utmpos(center.UtmPosition);
            utmCenter.x -= width / 2;
            utmCenter.y -= height / 2;

            Points.Add(utmCenter.ToLLA());
            
            utmCenter.x += width;
            Points.Add(utmCenter.ToLLA());

            utmCenter.y += height;
            Points.Add(utmCenter.ToLLA());

            utmCenter.x -= width;
            Points.Add(utmCenter.ToLLA());
        }

        public PhotoAreaPolygon(InternalWayPoint center, FieldOfView fov)
            : this(center, fov.width, fov.height)
        {
            
        }

        public List<PointLatLngAlt> getPoints()
        {
            List<PointLatLngAlt> points = new List<PointLatLngAlt>();

            Points.ForEach(x =>
            {
                points.Add(new PointLatLngAlt(x.Lat, x.Lng));
            });

            return points;
        }

    }
}
