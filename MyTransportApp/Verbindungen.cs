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
            dtagridverbindungen.Rows.Clear();

            Stationssuche neuesuche = new Stationssuche();
            string vonStation = comboboxvon.Text;
            string nachStation = comboboxNach.Text;
            DateTime zeitdatum = datetimepickerDatum.Value;
            DateTime uhrzeit = datimZeit.Value;

            Connections verbindungenrückgabe = neuesuche.Stationverbindungssuche(vonStation, nachStation, zeitdatum, uhrzeit);
            try
            {
                List<Connection> verbindungrückgabliste = verbindungenrückgabe.ConnectionList;

                foreach (Connection einzelneverbindung in verbindungrückgabliste.Take(4))
                {
                    
                    dtagridverbindungen.Rows.Add(einzelneverbindung.From.Station.Name, einzelneverbindung.To.Station.Name, Convert.ToDateTime(einzelneverbindung.From.Departure).ToString("MM-dd HH:mm"), Convert.ToDateTime(einzelneverbindung.To.Arrival).ToString("MM-dd HH:mm"), einzelneverbindung.To.Platform);
                }
            }
            catch
            {
                MessageBox.Show("Keine Verbindung gefunden");
                return;
            }
        }

        private void datagridVerbindungssuchedoppelklick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Vorschlage(object sender, EventArgs e)
        {
            comboboxvon.Items.Clear();

            Stationssuche neuesuche = new Stationssuche();

            List<Station> sucheresultat = neuesuche.Vorschlaege(comboboxvon.Text);
            try
            {
                foreach (Station station in sucheresultat)
                {
                    comboboxvon.Items.Add(station.Name);
                }
            }
            catch { }
            comboboxvon.Focus();
            comboboxvon.SelectionStart = comboboxvon.Text.Length;
        }

        private void VoerschlaegeNach(object sender, EventArgs e)
        {
            comboboxNach.Items.Clear();

            Stationssuche neuesuche = new Stationssuche();

            List<Station> sucheresultat = neuesuche.Vorschlaege(comboboxNach.Text);
            try
            {
                foreach (Station station in sucheresultat)
                {
                    comboboxNach.Items.Add(station.Name);
                }
            }
            catch { }
            comboboxNach.Focus();
            comboboxNach.SelectionStart = comboboxNach.Text.Length;
        }

        private void btnAufKarteAnzeigen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Karte formKarte = new Karte();
            formKarte.NeueKarte(comboboxvon.Text, comboboxNach.Text);
            formKarte.ShowDialog();
            this.Close();
        }
    }
}
