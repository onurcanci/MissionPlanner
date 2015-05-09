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

namespace AirSurvey
{
    public partial class AerialSurveyUI : Form
    {

        private static String ROUTE_POLYGON = "routePolygon";

        AirSurveyPlugin plugin;
        Dictionary<String, GMapOverlay> layers = new Dictionary<string, GMapOverlay>();
        GMapMarker currentMarker;

        PointLatLng startPoint;
        List<IBatteryModel> batteryModels = new List<IBatteryModel>();


        public AerialSurveyUI(AirSurveyPlugin plugin)
        {
            this.plugin = plugin;

            InitializeComponent();
            map.MapProvider = plugin.Host.FDMapType;

            layers.Add(ROUTE_POLYGON, new GMapOverlay("polygon"));
            map.Overlays.Add(layers[ROUTE_POLYGON]);
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
            List<PointLatLngAlt> boundaryPoints = new List<PointLatLngAlt>();
            plugin.Host.FPDrawnPolygon.Points.ForEach(x => {
                boundaryPoints.Add(new PointLatLngAlt(x));
            });

            List<PointLatLngAlt> grid = GridUtil.CreateGrid(boundaryPoints, CurrentState.fromDistDisplayUnit((double)flightAltitudeNm.Value), startPoint);

            drawPolygon();

            int i = 0;
            grid.ForEach(x => {
                layers[ROUTE_POLYGON].Markers.Add(new GMarkerGoogle(x, GMarkerGoogleType.yellow_dot) { ToolTipText =  i.ToString(), ToolTipMode = MarkerTooltipMode.OnMouseOver });
                i++;
            });


            int a = 100;
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

       
    }
}
