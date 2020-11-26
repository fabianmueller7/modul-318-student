
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
            this.btnsuchen = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Von = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ankunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtboxnach = new System.Windows.Forms.TextBox();
            this.lblnach = new System.Windows.Forms.Label();
            this.txtboxvon = new System.Windows.Forms.TextBox();
            this.lblvon = new System.Windows.Forms.Label();
            this.grpboxmenue.SuspendLayout();
            this.grpboxVerbindungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Enabled = false;
            this.btnVerbindungen.Location = new System.Drawing.Point(6, 25);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(129, 42);
            this.btnVerbindungen.TabIndex = 0;
            this.btnVerbindungen.Text = "Verbindungen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
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
            this.grpboxVerbindungen.Controls.Add(this.btnsuchen);
            this.grpboxVerbindungen.Controls.Add(this.listView1);
            this.grpboxVerbindungen.Controls.Add(this.txtboxnach);
            this.grpboxVerbindungen.Controls.Add(this.lblnach);
            this.grpboxVerbindungen.Controls.Add(this.txtboxvon);
            this.grpboxVerbindungen.Controls.Add(this.lblvon);
            this.grpboxVerbindungen.Location = new System.Drawing.Point(47, 108);
            this.grpboxVerbindungen.Name = "grpboxVerbindungen";
            this.grpboxVerbindungen.Size = new System.Drawing.Size(691, 330);
            this.grpboxVerbindungen.TabIndex = 6;
            this.grpboxVerbindungen.TabStop = false;
            this.grpboxVerbindungen.Text = "Verbindungssuche";
            // 
            // btnsuchen
            // 
            this.btnsuchen.Location = new System.Drawing.Point(551, 87);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(129, 33);
            this.btnsuchen.TabIndex = 5;
            this.btnsuchen.Text = "Suchen";
            this.btnsuchen.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Von,
            this.Nach,
            this.Abfahrt,
            this.Ankunft});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(674, 198);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtboxnach
            // 
            this.txtboxnach.Location = new System.Drawing.Point(571, 34);
            this.txtboxnach.Name = "txtboxnach";
            this.txtboxnach.Size = new System.Drawing.Size(100, 26);
            this.txtboxnach.TabIndex = 3;
            // 
            // lblnach
            // 
            this.lblnach.AutoSize = true;
            this.lblnach.Location = new System.Drawing.Point(518, 35);
            this.lblnach.Name = "lblnach";
            this.lblnach.Size = new System.Drawing.Size(46, 20);
            this.lblnach.TabIndex = 2;
            this.lblnach.Text = "Nach";
            // 
            // txtboxvon
            // 
            this.txtboxvon.Location = new System.Drawing.Point(70, 40);
            this.txtboxvon.Name = "txtboxvon";
            this.txtboxvon.Size = new System.Drawing.Size(100, 26);
            this.txtboxvon.TabIndex = 1;
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
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.grpboxVerbindungen);
            this.Controls.Add(this.grpboxmenue);
            this.Name = "Verbindungen";
            this.Text = "Verbindungen";
            this.grpboxmenue.ResumeLayout(false);
            this.grpboxVerbindungen.ResumeLayout(false);
            this.grpboxVerbindungen.PerformLayout();
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Von;
        private System.Windows.Forms.ColumnHeader Nach;
        private System.Windows.Forms.ColumnHeader Abfahrt;
        private System.Windows.Forms.ColumnHeader Ankunft;
        private System.Windows.Forms.TextBox txtboxnach;
        private System.Windows.Forms.Label lblnach;
        private System.Windows.Forms.TextBox txtboxvon;
        private System.Windows.Forms.Label lblvon;
        private System.Windows.Forms.Button btnsuchen;
    }
}

