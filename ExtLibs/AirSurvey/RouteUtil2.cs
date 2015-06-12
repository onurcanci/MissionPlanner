using System.Collections.Generic;
using GMap.NET;
using MissionPlanner.Utilities;

namespace AirSurvey
{
    class RouteUtil2
    {
        private List<PointLatLngAlt> _polygon = new List<PointLatLngAlt>();
        private List<utmpos> utmpositions;
        private int utmzone;
        public List<PointLatLngAlt> RoutePoints;

        public RouteUtil2(List<PointLatLng> polygon)
        {
            polygon.ForEach(x =>
            {
                _polygon.Add(new PointLatLngAlt(x));
            });

            utmzone = _polygon[0].GetUTMZone();
            utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, _polygon), utmzone);
        }

        public void Calculate(FieldOfView fov, double angle, PointLatLng startPoint)
        {
            if (_polygon.Count == 0)
                return;

            RoutePoints = new List<PointLatLngAlt>();

            if (utmpositions[0] != utmpositions[utmpositions.Count - 1])
                utmpositions.Add(utmpositions[0]);

            Rect area = PolygonHelper.getPolyMinMax(utmpositions);

            // get initial grid

            // used to determine the size of the outer grid area
            double diagdist = area.DiagDistance();

            // somewhere to store out generated lines
            List<GISUtils.LineLatLng> grid = new List<GISUtils.LineLatLng>();
            int lines = 0;

            // get start point bottom left
            double x = area.MidWidth;
            double y = area.MidHeight;



            // get left extent
            double xb1 = x;
            double yb1 = y;
            // to the left
            GISUtils.newpos(ref xb1, ref yb1, angle - 90, diagdist / 2 + fov.width);
            GISUtils.newpos(ref xb1, ref yb1, angle + 180, diagdist / 2 + fov.width);

            utmpos left = new utmpos(xb1, yb1, utmzone);


            // get right extent
            double xb2 = x;
            double yb2 = y;
            GISUtils.newpos(ref xb2, ref yb2, angle + 90, diagdist / 2 + fov.width);
            GISUtils.newpos(ref xb2, ref yb2, angle + 180, diagdist / 2 + fov.width);

            utmpos right = new utmpos(xb2, yb2, utmzone);


            // set start point to left hand side
            x = xb1;
            y = yb1;

            // draw the outergrid, this is a grid that cover the entire area of the rectangle plus more.
            while (lines < ((diagdist + fov.width * 2) / fov.width))
            {
                double nx = x;
                double ny = y;
                GISUtils.newpos(ref nx, ref ny, angle, diagdist + fov.width * 2);

                GISUtils.LineLatLng line = new GISUtils.LineLatLng();
                line.p1 = new utmpos(x, y, utmzone);
                line.p2 = new utmpos(nx, ny, utmzone);
                line.basepnt = new utmpos(x, y, utmzone);
                grid.Add(line);

                GISUtils.newpos(ref x, ref y, angle + 90, fov.width);
                lines++;
            }

            // find intersections with our polygon
            // store lines that dont have any intersections
            List<GISUtils.LineLatLng> remove = new List<GISUtils.LineLatLng>();

            int gridno = grid.Count;

            // cycle through our grid
            for (int a = 0; a < gridno; a++)
            {
                double closestdistance = double.MaxValue;
                double farestdistance = double.MinValue;

                utmpos closestpoint = utmpos.Zero;
                utmpos farestpoint = utmpos.Zero;

                // somewhere to store our intersections
                List<utmpos> matchs = new List<utmpos>();

                int b = -1;
                int crosses = 0;
                utmpos newutmpos = utmpos.Zero;
                foreach (utmpos pnt in utmpositions)
                {
                    b++;
                    if (b == 0)
                    {
                        continue;
                    }
                    newutmpos = GISUtils.FindLineIntersection(utmpositions[b - 1], utmpositions[b], grid[a].p1, grid[a].p2);
                    if (!newutmpos.IsZero)
                    {
                        crosses++;
                        matchs.Add(newutmpos);
                        if (closestdistance > grid[a].p1.GetDistance(newutmpos))
                        {
                            closestpoint.y = newutmpos.y;
                            closestpoint.x = newutmpos.x;
                            closestpoint.zone = newutmpos.zone;
                            closestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                        if (farestdistance < grid[a].p1.GetDistance(newutmpos))
                        {
                            farestpoint.y = newutmpos.y;
                            farestpoint.x = newutmpos.x;
                            farestpoint.zone = newutmpos.zone;
                            farestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                    }
                }
                if (crosses == 0) // outside our polygon
                {
                    if (!PolygonHelper.IsPointInPolygon(grid[a].p1, utmpositions) && !PolygonHelper.IsPointInPolygon(grid[a].p2, utmpositions))
                        remove.Add(grid[a]);
                }
                else if (crosses == 1) // bad - shouldnt happen
                {

                }
                else if (crosses == 2) // simple start and finish
                {
                    GISUtils.LineLatLng line = grid[a];
                    line.p1 = closestpoint;
                    line.p2 = farestpoint;
                    grid[a] = line;
                }
                else // multiple intersections
                {
                    GISUtils.LineLatLng line = grid[a];
                    remove.Add(line);

                    while (matchs.Count > 1)
                    {
                        GISUtils.LineLatLng newline = new GISUtils.LineLatLng();

                        closestpoint = GISUtils.findClosestPoint(closestpoint, matchs);
                        newline.p1 = closestpoint;
                        matchs.Remove(closestpoint);

                        closestpoint = GISUtils.findClosestPoint(closestpoint, matchs);
                        newline.p2 = closestpoint;
                        matchs.Remove(closestpoint);

                        newline.basepnt = line.basepnt;

                        grid.Add(newline);
                    }
                }
            }

            foreach (GISUtils.LineLatLng line in remove)
            {
                grid.Remove(line);
            }

            if (grid.Count == 0)
                return;


            // find closest line point to home
            utmpos startposutm = new utmpos(new PointLatLngAlt(startPoint));
            GISUtils.LineLatLng closest = GISUtils.findClosestLine(startposutm, grid);

            utmpos lastpnt;

            if (closest.p1.GetDistance(startposutm) < closest.p2.GetDistance(startposutm))
            {
                lastpnt = closest.p1;
            }
            else
            {
                lastpnt = closest.p2;
            }

            while (grid.Count > 0)
            {
                if (closest.p1.GetDistance(lastpnt) < closest.p2.GetDistance(lastpnt))
                {

                    RoutePoints.Add(closest.p1);

                    if (fov.height > 0)
                    {
                        for (int d = (int)(fov.height - ((closest.basepnt.GetDistance(closest.p1)) % fov.height));
                            d < (closest.p1.GetDistance(closest.p2));
                            d += (int)fov.height)
                        {
                            double ax = closest.p1.x;
                            double ay = closest.p1.y;

                            GISUtils.newpos(ref ax, ref ay, angle, d);
                            RoutePoints.Add((new utmpos(ax, ay, utmzone) { Tag = "M" }));

                        }
                    }


                    utmpos newend = GISUtils.newpos(closest.p2, angle, 0);
                    RoutePoints.Add(newend);

                    lastpnt = closest.p2;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;
                    closest = GISUtils.findClosestLine(newend, grid);
                }
                else
                {
                    RoutePoints.Add(closest.p2);

                    if (fov.height > 0)
                    {
                        for (int d = (int)((closest.basepnt.GetDistance(closest.p2)) % fov.height);
                            d < (closest.p1.GetDistance(closest.p2));
                            d += (int)fov.height)
                        {
                            double ax = closest.p2.x;
                            double ay = closest.p2.y;

                            GISUtils.newpos(ref ax, ref ay, angle, -d);
                            RoutePoints.Add((new utmpos(ax, ay, utmzone) { Tag = "M" }));

                        }
                    }

                    utmpos newend = GISUtils.newpos(closest.p1, angle, 0);
                    RoutePoints.Add(newend);

                    lastpnt = closest.p1;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;
                    closest = GISUtils.findClosestLine(newend, grid);
                }
            }
        }
    }
}
