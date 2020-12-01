using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using SwissTransport;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace MyTransportApp
{
    public partial class Naechste_Station : Form
    {
        private double GeraetX { get; set; }
        private double GeraetY { get; set; }
        GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

        void GetLocationProperty()
        {
         
            watcher.TryStart(false, TimeSpan.FromMilliseconds(10000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {

                   GeraetX = coord.Latitude;
                   GeraetY = coord.Longitude;
            }
            else
            {
              MessageBox.Show("Unbekannte Koordinaten!");
            }
        }

        public Naechste_Station()
        {
            InitializeComponent();
            watcher.Start();
            GetLocationProperty();
        }

        private void btnVerbindungen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Verbindungen formVerbindungen = new Verbindungen();
            formVerbindungen.ShowDialog();
            this.Close();
        }

        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abfahrtsplan formAbfahrtsplan = new Abfahrtsplan();
            formAbfahrtsplan.ShowDialog();
            this.Close();
        }

        private void btnKarte_Click(object sender, EventArgs e)
        {
            this.Hide();
            Karte formKarte = new Karte();
            formKarte.ShowDialog();
            this.Close();
        }

        private void btnGespeichert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gespeichert formGespeichert = new Gespeichert();
            formGespeichert.ShowDialog();
            this.Close();
        }

        private void btnsucheposition_Click(object sender, EventArgs e)
        {
            GeraetX = 47.094971;
            GeraetY = 8.346450;
            if (GeraetX != 0 && GeraetY != 0)
            {
                Stationssuche stationssuche = new Stationssuche();
                Stations naechstebahnhofe = stationssuche.Neachstestatonfinden(Convert.ToString(GeraetX), Convert.ToString(GeraetY));
                List<Station> nachstebahnhofliste = naechstebahnhofe.StationList;

                gmapNaechsteStaion.DragButton = MouseButtons.Left;
                gmapNaechsteStaion.CanDragMap = true;
                gmapNaechsteStaion.MapProvider = GMapProviders.GoogleMap;
                gmapNaechsteStaion.Position = new PointLatLng(GeraetX, GeraetY);
                gmapNaechsteStaion.MinZoom = 5;
                gmapNaechsteStaion.MaxZoom = 25;
                gmapNaechsteStaion.Zoom = 15;
                gmapNaechsteStaion.AutoScroll = true;
                g

                GMapOverlay markerOverlay = new GMapOverlay("makers");

                foreach (Station bahnhof in nachstebahnhofliste.Take(5))
                {              
                    markerOverlay.Markers.Add(new GMarkerGoogle(new GMap.NET.PointLatLng(bahnhof.Coordinate.YCoordinate, bahnhof.Coordinate.XCoordinate), GMarkerGoogleType.green_pushpin));
                    
                }
                gmapNaechsteStaion.Overlays.Add(markerOverlay);
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Unbekannte Koordinaten!");
            }
        }

    }
}
