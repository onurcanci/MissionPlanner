using GMap.NET;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirSurvey.Shapes;

namespace AirSurvey
{
    class RouteUtil
    {
        private List<PointLatLngAlt> _polygon= new List<PointLatLngAlt>();
        private List<utmpos> utmpositions;

        public List<utmpos> gridPoints = new List<utmpos>();
        public List<List<InternalWayPoint>> grid = new List<List<InternalWayPoint>>();
        
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

        public RouteUtil(List<PointLatLng> polygon)
        {
            polygon.ForEach(x =>
            {
                _polygon.Add(new PointLatLngAlt(x));
            });

            zone = _polygon[0].GetUTMZone();
            utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(zone,_polygon), zone);
        }

        public void calculate(FieldOfView fov, PointLatLng startPoint)
        {
            calculateGrid(fov);

            try
            {
                InternalWayPoint firstPoint = findFirstWayPoint(startPoint);

                List<InternalWayPoint> candidates = findAlternatives(firstPoint);

                candidates.ForEach(x =>
                {

                });

                int a = 0;

            }
            catch (RouteCalculationException ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }


        private List<InternalWayPoint> findAlternatives(InternalWayPoint point)
        {
            List<InternalWayPoint> candidates = new List<InternalWayPoint>();

            try
            {
                if (grid[point.column - 1][point.row - 1].active)
                {
                    candidates.Add(grid[point.column - 1][point.row - 1]);
                }
            }
            catch { }

            try {
                if (grid[point.column - 1][point.row].active)
                {
                    candidates.Add(grid[point.column - 1][point.row]);
                }
            }
            catch { }
            try {
                if (grid[point.column - 1][point.row + 1].active)
                {
                    candidates.Add(grid[point.column - 1][point.row + 1]);
                }
            }
            catch { }
            try
            {
                if (grid[point.column + 1][point.row - 1].active)
                {
                    candidates.Add(grid[point.column + 1][point.row - 1]);
                }
            }
            catch { }
            try
            {
                if (grid[point.column - 1][point.row].active)
                {
                    candidates.Add(grid[point.column - 1][point.row]);
                }
            }
            catch { }
            try
            {
                if (grid[point.column + 1][point.row + 1].active)
                {
                    candidates.Add(grid[point.column + 1][point.row + 1]);
                }
            }
            catch { }
            try
            {
                if (grid[point.column][point.row - 1].active)
                {
                    candidates.Add(grid[point.column][point.row - 1]);
                }
            }
            catch { }
            try
            {
                if (grid[point.column][point.row + 1].active)
                {
                    candidates.Add(grid[point.column][point.row + 1]);
                }
            }
            catch { }
            return candidates;
        }


        private InternalWayPoint findFirstWayPoint(PointLatLng startPoint)
        {
            if (startPoint != null)
            {
                List<InternalWayPoint> route = new List<InternalWayPoint>();
                InternalWayPoint temp = findClosestPoint(startPoint);

                if (temp == null)
                    throw new RouteCalculationException("No way points found please check your polygon");

                return temp;
            }

            throw new RouteCalculationException("You must select a startpoint from polygon points.");
        }

        private InternalWayPoint findClosestPoint(PointLatLng point)
        {
            InternalWayPoint closest = _waypoints[0];
            double distance = Double.MaxValue;

            utmpos referencePoint = new utmpos(new PointLatLngAlt(point));

            _waypoints.ForEach(wp =>
            {
                if (referencePoint.GetDistance(wp.UtmPosition) < distance)
                {
                    closest = wp;
                    distance = referencePoint.GetDistance(wp.UtmPosition);
                }
            });

            return closest;
        }

        private void calculateGrid(FieldOfView fov)
        {
            gridPoints.Clear();
            PointLatLngAlt leftTop = new PointLatLngAlt(OuterPolygon.Left, OuterPolygon.Top);
            PointLatLngAlt rightBottom = new PointLatLngAlt(OuterPolygon.Right, OuterPolygon.Bottom);

            List<PointLatLngAlt> outerPolygon = new List<PointLatLngAlt>();
            outerPolygon.Add(new PointLatLngAlt(OuterPolygon.Left, OuterPolygon.Top));
            outerPolygon.Add(new PointLatLngAlt(OuterPolygon.Right, OuterPolygon.Top));
            outerPolygon.Add(new PointLatLngAlt(OuterPolygon.Right, OuterPolygon.Bottom));
            outerPolygon.Add(new PointLatLngAlt(OuterPolygon.Left, OuterPolygon.Bottom));


            int rowIdx = 0;

            while (leftTop.Lat > rightBottom.Lat)
            {
                utmpos current = new utmpos(leftTop);
                utmpos next = GISUtils.addDistance(GISUtils.addDistance(current, 90, fov.width / 2), 180, fov.height / 2);
                int columnIdx = 0;
                grid.Add(new List<InternalWayPoint>());

                while (PolygonHelper.isPolygonsIntersect(outerPolygon, new PhotoAreaPolygon(new InternalWayPoint(next, columnIdx, rowIdx), fov).getPoints()))
                {
                    _waypoints.Add(new InternalWayPoint(next, columnIdx, rowIdx));
                    gridPoints.Add(next);

                    // To store way points in matrix format
                    grid[rowIdx].Add(new InternalWayPoint(next, columnIdx, rowIdx));

                    next = GISUtils.addDistance(next, 90, fov.width);
                    columnIdx++;

                }
                leftTop = GISUtils.addDistance(new utmpos(leftTop), 180, fov.height);
                rowIdx++;
            }


            // Disable waypoints that doesn't intersect with survey polygon
            WayPoints.ForEach(wp =>
            {
                PhotoAreaPolygon poly = new PhotoAreaPolygon(wp, fov.width, fov.height);

                wp.active = PolygonHelper.isPolygonsIntersect(_polygon, poly.getPoints());
                
            });

        }



    }
}
