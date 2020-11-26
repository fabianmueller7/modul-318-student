using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class Verbindungen : Form
    {
        public Verbindungen()
        {
            InitializeComponent();
            
            
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

        private void btnNaechsteStation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Naechste_Station formNaechsteStation = new Naechste_Station();
            formNaechsteStation.ShowDialog();
            this.Close();
        }

        private void btnGespeichert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gespeichert formGespeichert = new Gespeichert();
            formGespeichert.ShowDialog();
            this.Close();
        }

        private void btnVerbindungen_Click(object sender, EventArgs e)
        {

        }

        private void btnsuchen_Click(object sender, EventArgs e)
        {
            Stationssuche neuesuche = new Stationssuche();
            string vonStation = txtboxvon.Text;
            string nachStation = txtboxnach.Text;

            Connections verbindungenrückgabe = neuesuche.Stationverbindungssuche(vonStation, nachStation);

            List<Connection> verbindungrückgabliste = verbindungenrückgabe.ConnectionList;

            foreach (Connection  einzelneverbindung in verbindungrückgabliste)
            {
                dtagridverbindungen.Rows.Add(einzelneverbindung.From.Station.Name, einzelneverbindung.To.Station.Name, einzelneverbindung.From.DepartureTimestamp, einzelneverbindung.To.ArrivalTimestamp, einzelneverbindung.To.Platform);
            }
        }
    }
}
