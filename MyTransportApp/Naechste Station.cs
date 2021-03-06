﻿using System;
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

        void watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            GeoCoordinate coord = watcher.Position.Location;
            
            if (coord.IsUnknown != true)
            {
                GeraetX = coord.Latitude;
                GeraetY = coord.Longitude;

                try
                {
                    Stationssuche stationssuche = new Stationssuche();
                    Stations naechstebahnhofe = stationssuche.Neachstestatonfinden(Convert.ToString(GeraetX), Convert.ToString(GeraetY));
                    List<Station> nachstebahnhofliste = naechstebahnhofe.StationList;

                    foreach (Station bahnhof in nachstebahnhofliste.Take(5))
                    {
                        dgvNaechsteStation.Rows.Add(bahnhof.Name, bahnhof.Distance);
                    }
                    this.Refresh();
                    watcher.Stop();
                }
                catch { MessageBox.Show("Keine Station gefunden!"); return; }
            }
            else
            {
                MessageBox.Show("Unbekannte Koordinaten!");
                System.Threading.Thread.Sleep(1000);
            }           
        }

        public Naechste_Station()
        {           
            InitializeComponent();
            watcher.Start();
            watcher.TryStart(false, TimeSpan.FromMilliseconds(100000));
            watcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(watcher_StatusChanged) ;

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
    }
}
