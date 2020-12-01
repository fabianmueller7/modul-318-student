
namespace MyTransportApp
{
    partial class Naechste_Station
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpboxmenue = new System.Windows.Forms.GroupBox();
            this.btnGespeichert = new System.Windows.Forms.Button();
            this.btnNaechsteStation = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.grpboxNaechsteStation = new System.Windows.Forms.GroupBox();
            this.lblNaechsteStaton = new System.Windows.Forms.Label();
            this.btnsucheposition = new System.Windows.Forms.Button();
            this.gmapNaechsteStaion = new GMap.NET.WindowsForms.GMapControl();
            this.grpboxmenue.SuspendLayout();
            this.grpboxNaechsteStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxmenue
            // 
            this.grpboxmenue.Controls.Add(this.btnGespeichert);
            this.grpboxmenue.Controls.Add(this.btnNaechsteStation);
            this.grpboxmenue.Controls.Add(this.btnKarte);
            this.grpboxmenue.Controls.Add(this.btnAbfahrtstafel);
            this.grpboxmenue.Controls.Add(this.btnVerbindungen);
            this.grpboxmenue.Location = new System.Drawing.Point(49, 13);
            this.grpboxmenue.Name = "grpboxmenue";
            this.grpboxmenue.Size = new System.Drawing.Size(695, 71);
            this.grpboxmenue.TabIndex = 0;
            this.grpboxmenue.TabStop = false;
            this.grpboxmenue.Text = "Menü";
            // 
            // btnGespeichert
            // 
            this.btnGespeichert.Location = new System.Drawing.Point(557, 29);
            this.btnGespeichert.Name = "btnGespeichert";
            this.btnGespeichert.Size = new System.Drawing.Size(132, 36);
            this.btnGespeichert.TabIndex = 4;
            this.btnGespeichert.Text = "Gespeichert";
            this.btnGespeichert.UseVisualStyleBackColor = true;
            this.btnGespeichert.Click += new System.EventHandler(this.btnGespeichert_Click);
            // 
            // btnNaechsteStation
            // 
            this.btnNaechsteStation.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNaechsteStation.Enabled = false;
            this.btnNaechsteStation.Location = new System.Drawing.Point(406, 28);
            this.btnNaechsteStation.Name = "btnNaechsteStation";
            this.btnNaechsteStation.Size = new System.Drawing.Size(145, 37);
            this.btnNaechsteStation.TabIndex = 3;
            this.btnNaechsteStation.Text = "Nächste Station";
            this.btnNaechsteStation.UseVisualStyleBackColor = false;
            // 
            // btnKarte
            // 
            this.btnKarte.Location = new System.Drawing.Point(273, 27);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(127, 38);
            this.btnKarte.TabIndex = 2;
            this.btnKarte.Text = "Karte";
            this.btnKarte.UseVisualStyleBackColor = true;
            this.btnKarte.Click += new System.EventHandler(this.btnKarte_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(140, 26);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(127, 39);
            this.btnAbfahrtstafel.TabIndex = 1;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Location = new System.Drawing.Point(6, 25);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(128, 39);
            this.btnVerbindungen.TabIndex = 0;
            this.btnVerbindungen.Text = "Verbindungen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // grpboxNaechsteStation
            // 
            this.grpboxNaechsteStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxNaechsteStation.Controls.Add(this.gmapNaechsteStaion);
            this.grpboxNaechsteStation.Controls.Add(this.lblNaechsteStaton);
            this.grpboxNaechsteStation.Controls.Add(this.btnsucheposition);
            this.grpboxNaechsteStation.Location = new System.Drawing.Point(49, 125);
            this.grpboxNaechsteStation.Name = "grpboxNaechsteStation";
            this.grpboxNaechsteStation.Size = new System.Drawing.Size(682, 313);
            this.grpboxNaechsteStation.TabIndex = 1;
            this.grpboxNaechsteStation.TabStop = false;
            this.grpboxNaechsteStation.Text = "Nächste Station";
            // 
            // lblNaechsteStaton
            // 
            this.lblNaechsteStaton.AutoSize = true;
            this.lblNaechsteStaton.Location = new System.Drawing.Point(6, 35);
            this.lblNaechsteStaton.Name = "lblNaechsteStaton";
            this.lblNaechsteStaton.Size = new System.Drawing.Size(127, 20);
            this.lblNaechsteStaton.TabIndex = 1;
            this.lblNaechsteStaton.Text = "Nächste Station:";
            // 
            // btnsucheposition
            // 
            this.btnsucheposition.Location = new System.Drawing.Point(139, 35);
            this.btnsucheposition.Name = "btnsucheposition";
            this.btnsucheposition.Size = new System.Drawing.Size(87, 29);
            this.btnsucheposition.TabIndex = 0;
            this.btnsucheposition.Text = "Suchen";
            this.btnsucheposition.UseVisualStyleBackColor = true;
            this.btnsucheposition.Click += new System.EventHandler(this.btnsucheposition_Click);
            // 
            // gmapNaechsteStaion
            // 
            this.gmapNaechsteStaion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmapNaechsteStaion.Bearing = 0F;
            this.gmapNaechsteStaion.CanDragMap = true;
            this.gmapNaechsteStaion.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapNaechsteStaion.GrayScaleMode = false;
            this.gmapNaechsteStaion.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapNaechsteStaion.LevelsKeepInMemmory = 5;
            this.gmapNaechsteStaion.Location = new System.Drawing.Point(6, 70);
            this.gmapNaechsteStaion.MarkersEnabled = true;
            this.gmapNaechsteStaion.MaxZoom = 2;
            this.gmapNaechsteStaion.MinZoom = 2;
            this.gmapNaechsteStaion.MouseWheelZoomEnabled = true;
            this.gmapNaechsteStaion.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapNaechsteStaion.Name = "gmapNaechsteStaion";
            this.gmapNaechsteStaion.NegativeMode = false;
            this.gmapNaechsteStaion.PolygonsEnabled = true;
            this.gmapNaechsteStaion.RetryLoadTile = 0;
            this.gmapNaechsteStaion.RoutesEnabled = true;
            this.gmapNaechsteStaion.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapNaechsteStaion.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapNaechsteStaion.ShowTileGridLines = false;
            this.gmapNaechsteStaion.Size = new System.Drawing.Size(666, 237);
            this.gmapNaechsteStaion.TabIndex = 2;
            this.gmapNaechsteStaion.Zoom = 0D;
            // 
            // Naechste_Station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpboxNaechsteStation);
            this.Controls.Add(this.grpboxmenue);
            this.Name = "Naechste_Station";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naechste_Station";
            this.grpboxmenue.ResumeLayout(false);
            this.grpboxNaechsteStation.ResumeLayout(false);
            this.grpboxNaechsteStation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxmenue;
        private System.Windows.Forms.Button btnGespeichert;
        private System.Windows.Forms.Button btnNaechsteStation;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnVerbindungen;
        private System.Windows.Forms.GroupBox grpboxNaechsteStation;
        private System.Windows.Forms.Label lblNaechsteStaton;
        private System.Windows.Forms.Button btnsucheposition;
        private GMap.NET.WindowsForms.GMapControl gmapNaechsteStaion;
    }
}