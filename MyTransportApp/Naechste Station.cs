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

namespace MyTransportApp
{
    public partial class Naechste_Station : Form
    {
        static void GetLocationProperty()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
           
           watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                Console.WriteLine("Lat: {0}, Long: {1}",
                    coord.Latitude,
                    coord.Longitude);
            }
            else
            {
              Console.WriteLine("Unknown latitude and longitude.");
            }
        }
        public Naechste_Station()
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

        }
    }
}
