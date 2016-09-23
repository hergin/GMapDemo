using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace GMapTry
{
    public partial class Form1 : Form
    {
        GMapOverlay route = new GMapOverlay("route");

        public Form1()
        {
            InitializeComponent();
            next = textbox_location1;
            next.BackColor = Color.Yellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<PointLatLng> tempList = new List<PointLatLng>();
            tempList.Add(new PointLatLng(5, 5));
            tempList.Add(new PointLatLng(1, 1));
            tempList.Add(new PointLatLng(3, 3));
            tempList.Add(new PointLatLng(4, 4));
            tempList.Add(new PointLatLng(0, 0));

            sort(tempList);

            gmap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.ShowCenter = false;


            GMapOverlay I20 = new GMapOverlay("I20");

            string[] lines = Properties.Resources.I20.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Bitmap bmp = new Bitmap(Properties.Resources.dot, new Size(5, 5));
            foreach (string line in lines)
            {
                string[] langLong = line.Split(new char[] { ',' });
                GMapMarker marker =
                new GMarkerGoogle(
                    new PointLatLng(double.Parse(langLong[0]), double.Parse(langLong[1])),
                    bmp);
                marker.ToolTipText = "I20 at " + line;
                I20.Markers.Add(marker);
            }

            GMapOverlay I65 = new GMapOverlay("I65");

            lines = Properties.Resources.I65.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] langLong = line.Split(new char[] { ',' });
                GMapMarker marker =
                new GMarkerGoogle(
                    new PointLatLng(double.Parse(langLong[0]), double.Parse(langLong[1])),
                    bmp);
                marker.ToolTipText = "I65 at " + line;
                I65.Markers.Add(marker);
            }

            GMapOverlay I459 = new GMapOverlay("I459");

            lines = Properties.Resources.I459.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] langLong = line.Split(new char[] { ',' });
                GMapMarker marker =
                new GMarkerGoogle(
                    new PointLatLng(double.Parse(langLong[0]), double.Parse(langLong[1])),
                    bmp);
                marker.ToolTipText = "I459 at " + line;
                I459.Markers.Add(marker);
            }

            GMapOverlay I59 = new GMapOverlay("I59");

            lines = Properties.Resources.I59.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] langLong = line.Split(new char[] { ',' });
                GMapMarker marker =
                new GMarkerGoogle(
                    new PointLatLng(double.Parse(langLong[0]), double.Parse(langLong[1])),
                    bmp);
                marker.ToolTipText = "I59 at " + line;
                I59.Markers.Add(marker);
            }

            GMapOverlay I22 = new GMapOverlay("I22");

            lines = Properties.Resources.I22.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] langLong = line.Split(new char[] { ',' });
                GMapMarker marker =
                new GMarkerGoogle(
                    new PointLatLng(double.Parse(langLong[0]), double.Parse(langLong[1])),
                    bmp);
                marker.ToolTipText = "I22 at " + line;
                I22.Markers.Add(marker);
            }

            Bitmap hotspotBmp = new Bitmap(Properties.Resources.hotspot, new Size(50, 50));


            GMapOverlay hotspots = new GMapOverlay("hotspots");
            GMapMarker hotspot =
                new GMarkerGoogle(
                    new PointLatLng(33.8200890, -87.3135490),
                    hotspotBmp);
            hotspot.ToolTipText = "Hotspot";
            hotspots.Markers.Add(hotspot);

            hotspot =
                new GMarkerGoogle(
                    new PointLatLng(33.4441220, -86.9580590),
                    hotspotBmp);
            hotspot.ToolTipText = "Hotspot";
            hotspots.Markers.Add(hotspot);

            hotspot =
                new GMarkerGoogle(
                    new PointLatLng(33.4824330, -86.7090960),
                    hotspotBmp);
            hotspot.ToolTipText = "Hotspot";
            hotspots.Markers.Add(hotspot);

            hotspot =
                new GMarkerGoogle(
                    new PointLatLng(32.9834940, -86.6906810),
                    hotspotBmp);
            hotspot.ToolTipText = "Hotspot";
            hotspots.Markers.Add(hotspot);


            Bitmap vehicleBmp = new Bitmap(Properties.Resources.vehicle, new Size(50, 50));


            GMapOverlay vehicles = new GMapOverlay("vehicles");
            GMapMarker vehicle =
                new GMarkerGoogle(
                    new PointLatLng(33.3784590, -86.8201040),
                    vehicleBmp);
            vehicle.ToolTipText = "Vehicle";
            vehicles.Markers.Add(vehicle);

            vehicle =
                new GMarkerGoogle(
                    new PointLatLng(33.6742790, -86.5461920),
                    vehicleBmp);
            vehicle.ToolTipText = "Vehicle";
            vehicles.Markers.Add(vehicle);


            gmap.Overlays.Add(I20);
            gmap.Overlays.Add(I65);
            gmap.Overlays.Add(I459);
            gmap.Overlays.Add(I59);
            gmap.Overlays.Add(I22);
            gmap.Overlays.Add(route);

            gmap.Overlays.Add(hotspots);

            gmap.Overlays.Add(vehicles);

            // GMapOverlay routes = new GMapOverlay("roads");
            // List<PointLatLng> points = new List<PointLatLng>();
            // string[] lines = Properties.Resources.I20.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            // Array.Sort(lines);
            // foreach (string line in lines)
            // {
            //     string[] langLong = line.Split(new char[] { ',' });
            //     points.Add(new PointLatLng(double.Parse(langLong[0]), double.Parse(langLong[1])));
            // }
            // sort(points);
            // GMapRoute route = new GMapRoute(points, "I20");
            // route.Stroke = new Pen(Color.Red, 3);
            // routes.Routes.Add(route);
            // gmap.Overlays.Add(routes);

            gmap.SetPositionByKeywords("Birmingham, AL");
            //gmap.Position = new PointLatLng(33.518336, -86.825135);
        }

        void sort(List<PointLatLng> points)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                double closestOffset = Double.MaxValue;
                int index = i;
                for (int j = i + 1; j < points.Count; j++)
                {
                    double d = distance(points[i], points[j]);
                    if (d < closestOffset)
                    {
                        index = j;
                        closestOffset = d;
                    }
                }
                PointLatLng temp = new PointLatLng(points[i + 1].Lat, points[i + 1].Lng);
                points[i + 1] = new PointLatLng(points[index].Lat, points[index].Lng);
                points[index] = new PointLatLng(temp.Lat, temp.Lng); ;
            }
        }

        double distance(PointLatLng p1, PointLatLng p2)
        {
            return Math.Sqrt(Math.Pow(p1.Lat - p2.Lat, 2) * Math.Pow(p1.Lng - p2.Lng, 2));
        }

        TextBox next;
        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            next.BackColor = Color.White;

            next.Text = item.Position.Lat + "," + item.Position.Lng;
            if (next == textbox_location1)
                next = textbox_location2;
            else
                next = textbox_location1;

            next.BackColor = Color.Yellow;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_location1.Text) || string.IsNullOrEmpty(textbox_location2.Text))
            {
                MessageBox.Show("Please select two locations at least!", "Empty location");
                return;
            }
            string[] location1 = textbox_location1.Text.Split(new char[] { ',' });
            string[] location2 = textbox_location2.Text.Split(new char[] { ',' });
            var client = new HttpClient();
            client.BaseAddress = new Uri(@"http://www.yournavigation.org/api/dev/route.php?flat=" + location1[0] + "&flon=" + location1[1] + "&tlat=" + location2[0] + "&tlon=" + location2[1] + "&v=motorcar&fast=" + (radioButton_fastest.Checked ? "1" : "0") + "&layer=mapnik&instructions=0");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            HttpResponseMessage response = await client.GetAsync("");

            String result = await response.Content.ReadAsStringAsync();
            label_distance.Text = Regex.Match(result.Replace('\n', ' ').Replace('\r', ' '), "<distance>(.*?)</distance>").Groups[1].Value + " km";

            String coordinates = Regex.Match(result.Replace('\n', ' ').Replace('\r', ' '), "<coordinates>(.*?)</coordinates>").Groups[1].Value;
            Bitmap bmp = new Bitmap(Properties.Resources.dotGreen, new Size(15, 15));
            route.Markers.Clear();
            foreach (string coordinate in coordinates.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] langLong = coordinate.Split(new char[] { ',' });
                GMapMarker marker =
                new GMarkerGoogle(
                    new PointLatLng(double.Parse(langLong[0]), double.Parse(langLong[1])),
                    bmp);
                route.Markers.Add(marker);
            }
            gmap.Overlays.Remove(route);
            gmap.Overlays.Add(route);
            gmap.Refresh();
            gmap.ReloadMap();
        }
    }
}
