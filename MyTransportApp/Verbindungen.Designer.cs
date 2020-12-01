
namespace MyTransportApp
{
    partial class Verbindungen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.btnGespeichert = new System.Windows.Forms.Button();
            this.btnNaechsteStation = new System.Windows.Forms.Button();
            this.grpboxmenue = new System.Windows.Forms.GroupBox();
            this.grpboxVerbindungen = new System.Windows.Forms.GroupBox();
            this.lblabfahrt = new System.Windows.Forms.Label();
            this.comboboxNach = new System.Windows.Forms.ComboBox();
            this.comboboxvon = new System.Windows.Forms.ComboBox();
            this.datimZeit = new System.Windows.Forms.DateTimePicker();
            this.datetimepickerDatum = new System.Windows.Forms.DateTimePicker();
            this.dtagridverbindungen = new System.Windows.Forms.DataGridView();
            this.columnvon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnnach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnabfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columngleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.lblnach = new System.Windows.Forms.Label();
            this.lblvon = new System.Windows.Forms.Label();
            this.btnAufKarteAnzeigen = new System.Windows.Forms.Button();
            this.grpboxmenue.SuspendLayout();
            this.grpboxVerbindungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridverbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVerbindungen.Enabled = false;
            this.btnVerbindungen.Location = new System.Drawing.Point(6, 25);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(129, 42);
            this.btnVerbindungen.TabIndex = 0;
            this.btnVerbindungen.Text = "Verbindungen";
            this.btnVerbindungen.UseVisualStyleBackColor = false;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(141, 25);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(129, 42);
            this.btnAbfahrtstafel.TabIndex = 1;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnKarte
            // 
            this.btnKarte.Location = new System.Drawing.Point(276, 25);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(129, 42);
            this.btnKarte.TabIndex = 2;
            this.btnKarte.Text = "Karte";
            this.btnKarte.UseVisualStyleBackColor = true;
            this.btnKarte.Click += new System.EventHandler(this.btnKarte_Click);
            // 
            // btnGespeichert
            // 
            this.btnGespeichert.Location = new System.Drawing.Point(556, 25);
            this.btnGespeichert.Name = "btnGespeichert";
            this.btnGespeichert.Size = new System.Drawing.Size(129, 42);
            this.btnGespeichert.TabIndex = 3;
            this.btnGespeichert.Text = "Gespeichert";
            this.btnGespeichert.UseVisualStyleBackColor = true;
            this.btnGespeichert.Click += new System.EventHandler(this.btnGespeichert_Click);
            // 
            // btnNaechsteStation
            // 
            this.btnNaechsteStation.Location = new System.Drawing.Point(411, 25);
            this.btnNaechsteStation.Name = "btnNaechsteStation";
            this.btnNaechsteStation.Size = new System.Drawing.Size(139, 42);
            this.btnNaechsteStation.TabIndex = 4;
            this.btnNaechsteStation.Text = "Nächste Station";
            this.btnNaechsteStation.UseVisualStyleBackColor = true;
            this.btnNaechsteStation.Click += new System.EventHandler(this.btnNaechsteStation_Click);
            // 
            // grpboxmenue
            // 
            this.grpboxmenue.Controls.Add(this.btnVerbindungen);
            this.grpboxmenue.Controls.Add(this.btnGespeichert);
            this.grpboxmenue.Controls.Add(this.btnNaechsteStation);
            this.grpboxmenue.Controls.Add(this.btnAbfahrtstafel);
            this.grpboxmenue.Controls.Add(this.btnKarte);
            this.grpboxmenue.Location = new System.Drawing.Point(47, 12);
            this.grpboxmenue.Name = "grpboxmenue";
            this.grpboxmenue.Size = new System.Drawing.Size(691, 76);
            this.grpboxmenue.TabIndex = 5;
            this.grpboxmenue.TabStop = false;
            this.grpboxmenue.Text = "Menü";
            // 
            // grpboxVerbindungen
            // 
            this.grpboxVerbindungen.Controls.Add(this.btnAufKarteAnzeigen);
            this.grpboxVerbindungen.Controls.Add(this.lblabfahrt);
            this.grpboxVerbindungen.Controls.Add(this.comboboxNach);
            this.grpboxVerbindungen.Controls.Add(this.comboboxvon);
            this.grpboxVerbindungen.Controls.Add(this.datimZeit);
            this.grpboxVerbindungen.Controls.Add(this.datetimepickerDatum);
            this.grpboxVerbindungen.Controls.Add(this.dtagridverbindungen);
            this.grpboxVerbindungen.Controls.Add(this.btnsuchen);
            this.grpboxVerbindungen.Controls.Add(this.lblnach);
            this.grpboxVerbindungen.Controls.Add(this.lblvon);
            this.grpboxVerbindungen.Location = new System.Drawing.Point(47, 108);
            this.grpboxVerbindungen.Name = "grpboxVerbindungen";
            this.grpboxVerbindungen.Size = new System.Drawing.Size(691, 330);
            this.grpboxVerbindungen.TabIndex = 6;
            this.grpboxVerbindungen.TabStop = false;
            this.grpboxVerbindungen.Text = "Verbindungssuche";
            // 
            // lblabfahrt
            // 
            this.lblabfahrt.AutoSize = true;
            this.lblabfahrt.Location = new System.Drawing.Point(7, 77);
            this.lblabfahrt.Name = "lblabfahrt";
            this.lblabfahrt.Size = new System.Drawing.Size(62, 20);
            this.lblabfahrt.TabIndex = 11;
            this.lblabfahrt.Text = "Abfahrt";
            // 
            // comboboxNach
            // 
            this.comboboxNach.FormattingEnabled = true;
            this.comboboxNach.Location = new System.Drawing.Point(276, 40);
            this.comboboxNach.Name = "comboboxNach";
            this.comboboxNach.Size = new System.Drawing.Size(121, 28);
            this.comboboxNach.TabIndex = 10;
            this.comboboxNach.TextUpdate += new System.EventHandler(this.VoerschlaegeNach);
            // 
            // comboboxvon
            // 
            this.comboboxvon.FormattingEnabled = true;
            this.comboboxvon.Location = new System.Drawing.Point(69, 38);
            this.comboboxvon.Name = "comboboxvon";
            this.comboboxvon.Size = new System.Drawing.Size(121, 28);
            this.comboboxvon.TabIndex = 9;
            this.comboboxvon.TextUpdate += new System.EventHandler(this.Vorschlage);
            // 
            // datimZeit
            // 
            this.datimZeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datimZeit.Location = new System.Drawing.Point(276, 72);
            this.datimZeit.Name = "datimZeit";
            this.datimZeit.Size = new System.Drawing.Size(200, 26);
            this.datimZeit.TabIndex = 8;
            // 
            // datetimepickerDatum
            // 
            this.datetimepickerDatum.Location = new System.Drawing.Point(70, 72);
            this.datetimepickerDatum.Name = "datetimepickerDatum";
            this.datetimepickerDatum.Size = new System.Drawing.Size(200, 26);
            this.datetimepickerDatum.TabIndex = 7;
            // 
            // dtagridverbindungen
            // 
            this.dtagridverbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagridverbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnvon,
            this.columnnach,
            this.columnabfahrt,
            this.columnankunft,
            this.Columngleis});
            this.dtagridverbindungen.Location = new System.Drawing.Point(11, 126);
            this.dtagridverbindungen.Name = "dtagridverbindungen";
            this.dtagridverbindungen.RowHeadersWidth = 62;
            this.dtagridverbindungen.RowTemplate.Height = 28;
            this.dtagridverbindungen.Size = new System.Drawing.Size(674, 193);
            this.dtagridverbindungen.TabIndex = 6;
            this.dtagridverbindungen.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridVerbindungssuchedoppelklick);
            // 
            // columnvon
            // 
            this.columnvon.HeaderText = "Von";
            this.columnvon.MinimumWidth = 8;
            this.columnvon.Name = "columnvon";
            this.columnvon.ReadOnly = true;
            this.columnvon.Width = 150;
            // 
            // columnnach
            // 
            this.columnnach.HeaderText = "Nach";
            this.columnnach.MinimumWidth = 8;
            this.columnnach.Name = "columnnach";
            this.columnnach.ReadOnly = true;
            this.columnnach.Width = 150;
            // 
            // columnabfahrt
            // 
            this.columnabfahrt.HeaderText = "Abfahrt";
            this.columnabfahrt.MinimumWidth = 8;
            this.columnabfahrt.Name = "columnabfahrt";
            this.columnabfahrt.ReadOnly = true;
            this.columnabfahrt.Width = 150;
            // 
            // columnankunft
            // 
            this.columnankunft.HeaderText = "Ankunft";
            this.columnankunft.MinimumWidth = 8;
            this.columnankunft.Name = "columnankunft";
            this.columnankunft.ReadOnly = true;
            this.columnankunft.Width = 150;
            // 
            // Columngleis
            // 
            this.Columngleis.HeaderText = "Gleis";
            this.Columngleis.MinimumWidth = 8;
            this.Columngleis.Name = "Columngleis";
            this.Columngleis.ReadOnly = true;
            this.Columngleis.Width = 150;
            // 
            // btnsuchen
            // 
            this.btnsuchen.Location = new System.Drawing.Point(551, 87);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(129, 33);
            this.btnsuchen.TabIndex = 5;
            this.btnsuchen.Text = "Suchen";
            this.btnsuchen.UseVisualStyleBackColor = true;
            this.btnsuchen.Click += new System.EventHandler(this.btnsuchen_Click);
            // 
            // lblnach
            // 
            this.lblnach.AutoSize = true;
            this.lblnach.Location = new System.Drawing.Point(224, 41);
            this.lblnach.Name = "lblnach";
            this.lblnach.Size = new System.Drawing.Size(46, 20);
            this.lblnach.TabIndex = 2;
            this.lblnach.Text = "Nach";
            // 
            // lblvon
            // 
            this.lblvon.AutoSize = true;
            this.lblvon.Location = new System.Drawing.Point(25, 40);
            this.lblvon.Name = "lblvon";
            this.lblvon.Size = new System.Drawing.Size(38, 20);
            this.lblvon.TabIndex = 0;
            this.lblvon.Text = "Von";
            // 
            // btnAufKarteAnzeigen
            // 
            this.btnAufKarteAnzeigen.Location = new System.Drawing.Point(506, 33);
            this.btnAufKarteAnzeigen.Name = "btnAufKarteAnzeigen";
            this.btnAufKarteAnzeigen.Size = new System.Drawing.Size(174, 41);
            this.btnAufKarteAnzeigen.TabIndex = 12;
            this.btnAufKarteAnzeigen.Text = "Auf Karte anzeigen";
            this.btnAufKarteAnzeigen.UseVisualStyleBackColor = true;
            this.btnAufKarteAnzeigen.Click += new System.EventHandler(this.btnAufKarteAnzeigen_Click);
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.grpboxVerbindungen);
            this.Controls.Add(this.grpboxmenue);
            this.Name = "Verbindungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verbindungen";
            this.grpboxmenue.ResumeLayout(false);
            this.grpboxVerbindungen.ResumeLayout(false);
            this.grpboxVerbindungen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridverbindungen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerbindungen;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.Button btnGespeichert;
        private System.Windows.Forms.Button btnNaechsteStation;
        private System.Windows.Forms.GroupBox grpboxmenue;
        private System.Windows.Forms.GroupBox grpboxVerbindungen;
        private System.Windows.Forms.Label lblnach;
        private System.Windows.Forms.Label lblvon;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.DataGridView dtagridverbindungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnvon;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnnach;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnabfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columngleis;
        private System.Windows.Forms.DateTimePicker datetimepickerDatum;
        private System.Windows.Forms.DateTimePicker datimZeit;
        private System.Windows.Forms.ComboBox comboboxvon;
        private System.Windows.Forms.ComboBox comboboxNach;
        private System.Windows.Forms.Label lblabfahrt;
        private System.Windows.Forms.Button btnAufKarteAnzeigen;
    }
}

