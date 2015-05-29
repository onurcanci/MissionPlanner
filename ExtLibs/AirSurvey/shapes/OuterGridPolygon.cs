using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey.Shapes
{
    class OuterGridPolygon : GMapPolygon
    {
        public OuterGridPolygon(RectLatLng area)
            : base(new List<PointLatLng>(), "OuterGridOverlay")
        {
            Points.Add(new PointLatLng(area.Left, area.Top));
            Points.Add(new PointLatLng(area.Right, area.Top));
            Points.Add(new PointLatLng(area.Right, area.Bottom));
            Points.Add(new PointLatLng(area.Left, area.Bottom));

            Fill = new SolidBrush(Color.FromArgb(60, Color.Pink));
            Stroke = new Pen(Color.Red, 1);
            Stroke.DashPattern = new float[] { 5, 5 };
        }
    }
}
