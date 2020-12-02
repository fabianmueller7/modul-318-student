using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
                btnsend.Enabled = true;
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
            try
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
            catch { return; }
        }

        private void VoerschlaegeNach(object sender, EventArgs e)
        {
            try
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
            catch { return; }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                var dataGridViewlist = new List<string>();
                foreach (DataGridViewRow row in dtagridverbindungen.SelectedRows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        try
                        {
                            dataGridViewlist.Add(cell.Value.ToString());
                        }
                        catch { MessageBox.Show("Keine Daten ausgewählt"); return; }
                    }
                }
                if (dataGridViewlist != null) System.Diagnostics.Process.Start("mailto:" + "?subject=Verbindung" + "&body=Von: " + dataGridViewlist[0] + " am "+ dataGridViewlist[2] + " Nach: " + dataGridViewlist[1] +" bis " + dataGridViewlist[3] + ", Gleis: " + dataGridViewlist[4]);
            }
            catch
            {
                MessageBox.Show("Wählen sie eine Reihe aus.");
            }
        }

        private void speichern(object sender, DataGridViewCellMouseEventArgs e)
        {
            string speicherreihe = dtagridverbindungen.SelectedRows.ToString();           

            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(speicherreihe, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
            };
            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }
    }
}
