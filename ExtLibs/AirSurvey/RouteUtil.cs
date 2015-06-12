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
        private static int VERTICAL_DIRECTION = 0;
        private static int HORIZONTAL_DIRECTION = 1;

        private static int INCREMENT = 0;
        private static int DECREMENT = 1;

        public Route route = new Route();
        private List<PointLatLngAlt> _polygon= new List<PointLatLngAlt>();
        private List<utmpos> utmpositions;

        public List<utmpos> gridPoints = new List<utmpos>();
        public List<List<InternalWayPoint>> grid = new List<List<InternalWayPoint>>();
        
        private List<InternalWayPoint> _waypoints = new List<InternalWayPoint>();

        public List<PointLatLngAlt> Polygon
        {
            get { return _polygon; }
        }
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
                return PolygonHelper.getPolyMinMax(_polygon);
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

        public void Calculate(FieldOfView fov, PointLatLng startPoint)
        {
            CalculateGrid(fov);
            route = new Route();


            Boolean isStartInWayPoints = false;
            grid.ForEach(y => {
                List<InternalWayPoint> wp = y;
                wp.ForEach(x =>
                {
                    if(PolygonHelper.IsPointInPolygon(new PhotoAreaPolygon(x,fov).getPoints(), ((InternalWayPoint)x).UtmPosition.ToLLA() )){
                        isStartInWayPoints = true;
                        return;
                    }
                });
            });
            
            route.WayPoints.Add(new InternalWayPoint(new utmpos (new PointLatLngAlt(startPoint)),!isStartInWayPoints,-1,-1 ));            
            

            int direction = VERTICAL_DIRECTION;
            int vOperation = INCREMENT;
            int hOperation = INCREMENT;
            int row = 0;
            int col = 0;

            try
            {
                InternalWayPoint firstPoint = FindFirstWayPoint(startPoint);

                if (firstPoint.row > grid.Count / 2)
                {
                    vOperation = DECREMENT;
                }

                if (firstPoint.column > grid[0].Count / 2)
                {
                    hOperation = DECREMENT;
                }

                if (Math.Abs(OuterPolygon.Left - OuterPolygon.Right) < Math.Abs(OuterPolygon.Bottom - OuterPolygon.Top))
                {
                    
                    int i = (vOperation == INCREMENT ? 0 : grid.Count - 1);
                    while (true)
                    {
                        if (vOperation == INCREMENT && grid.Count == i)
                            break;

                        if (vOperation == DECREMENT && i < 0)
                            break;


                        // Horizontal movement
                        int k = (hOperation == INCREMENT ? 0 : grid[0].Count - 1);
                        while (true)
                        {
                            if (hOperation == INCREMENT && grid[0].Count == k)
                                break;

                            if (hOperation == DECREMENT && k < 0)
                                break;


                            if (grid[i][k].active)
                            {
                                route.WayPoints.Add(grid[i][k]);
                            }

                            if (hOperation == INCREMENT)
                            {
                                k++;
                            }
                            else
                            {
                                k--;
                            }
                        }
                        // End of the horizontal


                        if (vOperation == INCREMENT)
                        {
                            i++;
                        }
                        else
                        {
                            i--;
                        }

                        hOperation = hOperation == INCREMENT ? DECREMENT : INCREMENT;
                    }
                }
                else
                {



                    // Horizontal movement
                    int x = (hOperation == INCREMENT ? 0 : grid[0].Count - 1);
                    while (true)
                    {
                        if (hOperation == INCREMENT && grid[0].Count == x)
                            break;

                        if (hOperation == DECREMENT && x < 0)
                            break;

                            int y = (vOperation == INCREMENT ? 0 : grid.Count - 1);
                            while (true)
                            {
                                if (vOperation == INCREMENT && grid.Count == y)
                                    break;

                                if (vOperation == DECREMENT && y < 0)
                                    break;

                                if (grid[y][x].active)
                                {
                                    route.WayPoints.Add(grid[y][x]);
                                }

                                if (vOperation == INCREMENT)
                                {
                                    y++;
                                }
                                else
                                {
                                    y--;
                                }
                            }

                        vOperation = vOperation == INCREMENT ? DECREMENT : INCREMENT;
                        if (hOperation == INCREMENT)
                            x++;
                        else
                            x--;
                    }
                    // End of the horizontal

                }

            }
            catch (RouteCalculationException ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        //public void calculate(FieldOfView fov, PointLatLng startPoint)
        //{
        //    calculateGrid(fov);

        //    try
        //    {
        //        InternalWayPoint firstPoint = findFirstWayPoint(startPoint);

        //        List<InternalWayPoint> candidates = findAlternatives(firstPoint);
        //        List<Route> routes = new List<Route>();

        //        candidates.ForEach(x =>
        //        {
        //            Route route = new Route();
        //            route.WayPoints.Add(x);
        //            route.cost = 1f;

        //            routes.Add(findBest(route));
        //        });

        //        Route bestRoute = routes[0];
        //        routes.ForEach(r =>
        //        {
        //            if (r.cost < bestRoute.cost)
        //                bestRoute = r;
        //        });

        //        int a = 0;

        //    }
        //    catch (RouteCalculationException ex)
        //    {
        //        CustomMessageBox.Show(ex.Message);
        //    }
        //}

        private Route FindBest(Route route)
        {
            List<InternalWayPoint> candidates = FindAlternatives(route.WayPoints.Last());
            Route bestRoute = route;

            if (candidates.Count == 0)
            {
                return route.clone();
            }
            else
            {
                candidates.ForEach(x =>
                {
                    if (!route.WayPoints.Contains(x))
                    {
                        Route newRoute = route.clone();
                        //newRoute.increaseDepth();
                        newRoute.WayPoints.Add(x);
                        newRoute.cost += 1; // TODO : add angle cost here

                        //if (newRoute.depth < 5)
                        //{
                            Route alternativeRoute = FindBest(newRoute);
                            if (bestRoute == route || (bestRoute != null && bestRoute.cost > alternativeRoute.cost))
                            {
                                bestRoute = alternativeRoute;
                            }
                        //}
                    
                    }
                });
            }

            return bestRoute;
        }

        private double CalculateAngleCost(InternalWayPoint p1, InternalWayPoint p2, InternalWayPoint p3){

            double previousAngle = calculateAngle(p1, p2);
            double currentAngle = calculateAngle(p2, p3);

            if (previousAngle != currentAngle)
            {
                return Math.Abs(previousAngle - currentAngle) / 45 * 0.1 + Math.Abs(previousAngle - currentAngle) > 0 ? 0.414 : 0;
            }

            return 0;
        }

        private double calculateAngle(InternalWayPoint p1, InternalWayPoint p2)
        {
            float xDiff = p2.column - p1.column;
            float yDiff = p2.row - p1.row;
            return Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
        }

        private List<InternalWayPoint> FindAlternatives(InternalWayPoint point)
        {
            List<InternalWayPoint> candidates = new List<InternalWayPoint>();

            try
            {
                if (grid[point.row - 1][point.column - 1].active)
                {
                    candidates.Add(grid[point.row - 1][point.column - 1]);
                }
            }
            catch { }

            try {
                if (grid[point.row - 1][point.column].active)
                {
                    candidates.Add(grid[point.row - 1][point.column]);
                }
            }
            catch { }
            try {
                if (grid[point.row - 1][point.column + 1].active)
                {
                    candidates.Add(grid[point.row - 1][point.column + 1]);
                }
            }
            catch { }
            try
            {
                if (grid[point.row + 1][point.column - 1].active)
                {
                    candidates.Add(grid[point.row + 1][point.column - 1]);
                }
            }
            catch { }
            try
            {
                if (grid[point.row + 1][point.column + 1].active)
                {
                    candidates.Add(grid[point.row + 1][point.column + 1]);
                }
            }
            catch { }
            try
            {
                if (grid[point.row][point.column - 1].active)
                {
                    candidates.Add(grid[point.row][point.column - 1]);
                }
            }
            catch { }
            try
            {
                if (grid[point.row][point.column + 1].active)
                {
                    candidates.Add(grid[point.row][point.column + 1]);
                }
            }
            catch { }
            try
            {
                if (grid[point.row + 1][point.column].active)
                {
                    candidates.Add(grid[point.row + 1][point.column]);
                }
            }
            catch { }
            return candidates;
        }


        private InternalWayPoint FindFirstWayPoint(PointLatLng startPoint)
        {
            if (startPoint != null)
            {
                List<InternalWayPoint> route = new List<InternalWayPoint>();
                InternalWayPoint temp = FindClosestPoint(startPoint);

                if (temp == null)
                    throw new RouteCalculationException("No way points found please check your polygon");

                return temp;
            }

            throw new RouteCalculationException("You must select a startpoint from polygon points.");
        }

        private InternalWayPoint FindClosestPoint(PointLatLng point)
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

        public void CalculateGrid(FieldOfView fov)
        {
            gridPoints.Clear();
            WayPoints.Clear();
            grid.Clear();

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
                    InternalWayPoint wp = new InternalWayPoint(next, columnIdx, rowIdx);
                    _waypoints.Add(wp);
                    gridPoints.Add(next);

                    // To store way points in matrix format
                    grid[rowIdx].Add(wp);

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
