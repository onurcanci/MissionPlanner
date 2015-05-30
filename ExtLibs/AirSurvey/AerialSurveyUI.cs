using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MissionPlanner;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirSurvey.Shapes;

namespace AirSurvey
{
    public partial class AerialSurveyUI : Form
    {

        private static String ROUTE_POLYGON = "routePolygon";
        private static String INTERNAL_SHAPES = "internalShapesLayer";


        AirSurveyPlugin plugin;
        Dictionary<String, GMapOverlay> layers = new Dictionary<string, GMapOverlay>();
        GMapMarker currentMarker;

        PointLatLng startPoint;
        List<IBatteryModel> batteryModels = new List<IBatteryModel>();
        ICameraModel cameraModel = new GenericCameraModel();
        RouteUtil route;


        public AerialSurveyUI(AirSurveyPlugin plugin)
        {
            this.plugin = plugin;
            route = new RouteUtil(plugin.Host.FPDrawnPolygon.Points);

            InitializeComponent();
            map.MapProvider = plugin.Host.FDMapType;

            layers.Add(ROUTE_POLYGON, new GMapOverlay("polygon"));
            layers.Add(INTERNAL_SHAPES, new GMapOverlay("polygon2"));
            map.Overlays.Add(layers[ROUTE_POLYGON]);
            map.Overlays.Add(layers[INTERNAL_SHAPES]);
            layers[ROUTE_POLYGON].Polygons.Add(plugin.Host.FPDrawnPolygon);
            drawPolygon();
        }

        private void drawPolygon()
        {
            layers[ROUTE_POLYGON].Markers.Clear();

            plugin.Host.FPDrawnPolygon.Points.ForEach(x =>
            {
                GMarkerGoogle marker = new GMarkerGoogle(x, GMarkerGoogleType.green);
                layers[ROUTE_POLYGON].Markers.Add(marker);
            });
            map.ZoomAndCenterMarkers("polygon");
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (batteryModelCmb.SelectedItem == null)
                    throw new FormValidationException("Please select a battery model");

                if (maximumSpeedNm.Value == 0)
                    throw new FormValidationException("Please enter maximum speed");

                if (flightAltitudeNm.Value == 0)
                    throw new FormValidationException("Please enter flight altitude");

                if (sensorWidth.Value == 0)
                    throw new FormValidationException("Please enter sensor width");

                if (sensorHeight.Value == 0)
                    throw new FormValidationException("Please enter sensor height");

                if (focalLength.Value == 0)
                    throw new FormValidationException("Please enter focal length");


                List<PointLatLngAlt> boundaryPoints = new List<PointLatLngAlt>();
                plugin.Host.FPDrawnPolygon.Points.ForEach(x =>
                {
                    boundaryPoints.Add(new PointLatLngAlt(x));
                });

                List<PointLatLngAlt> grid = GridUtil.CreateGrid(boundaryPoints, CurrentState.fromDistDisplayUnit((double)flightAltitudeNm.Value), startPoint);

                drawPolygon();

                int i = 0;
                grid.ForEach(x =>
                {
                    layers[ROUTE_POLYGON].Markers.Add(new GMarkerGoogle(x, GMarkerGoogleType.yellow_dot) { ToolTipText = i.ToString(), ToolTipMode = MarkerTooltipMode.OnMouseOver });
                    i++;
                });


                int a = 100;
            }
            catch (FormValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void map_OnMarkerEnter(GMapMarker item)
        {
            currentMarker = item;
        }

        private void map_OnMarkerLeave(GMapMarker item)
        {
            currentMarker = null;
        }

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                markerMenu.Show(new Point(e.Location.X + this.Location.X , e.Location.Y + this.Location.Y));
            }
        }

        private void setAsStartPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentMarker != null)
            {
                startPoint = currentMarker.Position;
                currentMarker.ToolTipMode = MarkerTooltipMode.Always;
                currentMarker.ToolTipText = "Start point of the route";


                layers[ROUTE_POLYGON].Markers.ForEach(x => {
                    if (x.Position != startPoint)
                    {
                        x.ToolTipText = "";
                        x.ToolTipMode = MarkerTooltipMode.Never;
                    }
                });

            }
        }

        private void AerialSurveyUI_Load(object sender, EventArgs e)
        {

            try
            {
                var batteryModel = typeof(IBatteryModel);
                var models = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => batteryModel.IsAssignableFrom(p) && !p.IsInterface);

                models.ForEach(x =>
                {
                    IBatteryModel model = (IBatteryModel)Activator.CreateInstance(x);
                    batteryModelCmb.Items.Add(model.getName());

                    batteryModels.Add(model);
                });
            }
            catch (Exception ex) { }

        }

        private void calculateBtnClick(object sender, EventArgs e)
        {
            try
            {
                if (batteryModelCmb.SelectedItem == null)
                    throw new FormValidationException("Please select a battery model");

                if (maximumSpeedNm.Value == 0)
                    throw new FormValidationException("Please enter maximum speed");

                if (flightAltitudeNm.Value == 0)
                    throw new FormValidationException("Please enter flight altitude");

                if (sensorWidth.Value == 0)
                    throw new FormValidationException("Please enter sensor width");

                if (sensorHeight.Value == 0)
                    throw new FormValidationException("Please enter sensor height");

                if (focalLength.Value == 0)
                    throw new FormValidationException("Please enter focal length");

                cameraValuesChanged(null, null);

                drawOuterPolygon();
                FieldOfView fov = cameraModel.calculateFov(Int32.Parse(flightAltitudeNm.Value.ToString()));
                route.calculate(fov,startPoint);

                drawInternals();
            }
            catch (FormValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void drawInternals()
        {
            layers[INTERNAL_SHAPES].Polygons.Clear();
            layers[INTERNAL_SHAPES].Markers.Clear();
            layers[INTERNAL_SHAPES].Clear();

            drawOuterPolygon();
            drawWayPoints();
        }

        private void drawWayPoints()
        {
            FieldOfView fov = cameraModel.calculateFov(Int32.Parse(flightAltitudeNm.Value.ToString()));

            route.WayPoints.ForEach(wayPoint =>
            {
                if(chkPhotoWayPoints.Checked)
                    layers[INTERNAL_SHAPES].Markers.Add(new GMarkerGoogle(wayPoint.UtmPosition.ToLLA(), wayPoint.active ? GMarkerGoogleType.yellow_dot : GMarkerGoogleType.red_dot) { ToolTipText = "Waypoint [" + wayPoint.row + "][" + wayPoint.column + "]", ToolTipMode = MarkerTooltipMode.OnMouseOver });

                if(chkPhotoAreas.Checked)
                    layers[INTERNAL_SHAPES].Polygons.Add(new PhotoAreaPolygon(wayPoint, fov.width, fov.height));
            });
        }

        private void drawOuterPolygon()
        {
            if (chkOuterGrid.Checked)
                layers[INTERNAL_SHAPES].Polygons.Add(new OuterGridPolygon(route.OuterPolygon));
        }

        private void cameraValuesChanged(object sender, EventArgs e)
        {
            cameraModel.setSensorWidth(float.Parse(sensorWidth.Value.ToString()));
            cameraModel.setSensorHeight(float.Parse(sensorHeight.Value.ToString()));
            cameraModel.setFocalLength(Int32.Parse(focalLength.Value.ToString()));

            FieldOfView fov = cameraModel.calculateFov(Int32.Parse(flightAltitudeNm.Value.ToString()));
            lblFovDimensions.Text = fov.width.ToString() + "x" + fov.height.ToString()+" m";
        }

        private void chkOuterGrid_CheckedChanged(object sender, EventArgs e)
        {
            drawOuterPolygon();
        }

        private void map_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng point = map.FromLocalToLatLng(e.X, e.Y);
            lblLat.Text = point.Lat.ToString();
            lblLon.Text = point.Lng.ToString();

        }

       
    }
}
