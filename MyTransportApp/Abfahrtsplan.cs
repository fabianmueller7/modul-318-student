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
    public partial class Abfahrtsplan : Form
    {
        public Abfahrtsplan()
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

        private void btnKarte_Click(object sender, EventArgs e)
        {
            this.Hide();
            Karte formKarte = new Karte();
            formKarte.ShowDialog();
            this.Close();
        }

        private void btnNaechStestation_Click(object sender, EventArgs e)
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

        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {

        }
    }
}
