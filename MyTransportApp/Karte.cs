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
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using SwissTransport;


namespace MyTransportApp
{
    public partial class Karte : Form
    {
        private double vonX;
        private double vonY;

        public Karte()
        {
            InitializeComponent();
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

        private void btnGespeichert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gespeichert formGespeichert = new Gespeichert();
            formGespeichert.ShowDialog();
            this.Close();
        }

        private void NaechsteStation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Naechste_Station formNaechsteStation = new Naechste_Station();
            formNaechsteStation.ShowDialog();
            this.Close();

        }

        private void btnKarte_Click(object sender, EventArgs e)
        {

        }
        
        public void Setvonkodinaten(Coordinate value)
        {
            vonX = value.XCoordinate;
            vonY = value.YCoordinate;
        }


        private void btnSucheStaton_Click(object sender, EventArgs e)
        {
            Stationssuche neuesuche = new Stationssuche();

            Setvonkodinaten(neuesuche.GetKordinaten(txtboxstation.Text));
            gmapKarte.DragButton = MouseButtons.Left;
            gmapKarte.CanDragMap = true;
            gmapKarte.MapProvider = GMapProviders.GoogleMap;
            gmapKarte.Position = new PointLatLng(vonX, vonY);
            gmapKarte.MinZoom = 5;
            gmapKarte.MaxZoom = 25;
            gmapKarte.Zoom = 10;
            gmapKarte.AutoScroll = true;

            GMapOverlay markerOverlay = new GMapOverlay("makers");

            GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(vonY, vonX), GMarkerGoogleType.green_pushpin);
            markerOverlay.Markers.Add(marker);
            gmapKarte.Overlays.Add(markerOverlay);
            gmapKarte.Refresh();
        }
    }
}
