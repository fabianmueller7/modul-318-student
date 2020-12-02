
namespace MyTransportApp
{
    partial class Karte
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.grpboxKarte = new System.Windows.Forms.GroupBox();
            this.btnSucheStaton = new System.Windows.Forms.Button();
            this.txtboxstation = new System.Windows.Forms.TextBox();
            this.gmapKarte = new GMap.NET.WindowsForms.GMapControl();
            this.grpboxmenue.SuspendLayout();
            this.grpboxKarte.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxmenue
            // 
            this.grpboxmenue.Controls.Add(this.button1);
            this.grpboxmenue.Controls.Add(this.btnKarte);
            this.grpboxmenue.Controls.Add(this.btnAbfahrtstafel);
            this.grpboxmenue.Controls.Add(this.btnVerbindungen);
            this.grpboxmenue.Location = new System.Drawing.Point(34, 12);
            this.grpboxmenue.Name = "grpboxmenue";
            this.grpboxmenue.Size = new System.Drawing.Size(692, 76);
            this.grpboxmenue.TabIndex = 12;
            this.grpboxmenue.TabStop = false;
            this.grpboxmenue.Text = "Menü";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nächste Station";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NaechsteStation_Click);
            // 
            // btnKarte
            // 
            this.btnKarte.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnKarte.Enabled = false;
            this.btnKarte.Location = new System.Drawing.Point(268, 26);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(125, 38);
            this.btnKarte.TabIndex = 2;
            this.btnKarte.Text = "Karte";
            this.btnKarte.UseVisualStyleBackColor = false;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(137, 25);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(125, 39);
            this.btnAbfahrtstafel.TabIndex = 1;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Location = new System.Drawing.Point(6, 24);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(125, 40);
            this.btnVerbindungen.TabIndex = 0;
            this.btnVerbindungen.Text = "Verbindungen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // grpboxKarte
            // 
            this.grpboxKarte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxKarte.Controls.Add(this.btnSucheStaton);
            this.grpboxKarte.Controls.Add(this.txtboxstation);
            this.grpboxKarte.Controls.Add(this.gmapKarte);
            this.grpboxKarte.Location = new System.Drawing.Point(49, 112);
            this.grpboxKarte.Name = "grpboxKarte";
            this.grpboxKarte.Size = new System.Drawing.Size(677, 326);
            this.grpboxKarte.TabIndex = 11;
            this.grpboxKarte.TabStop = false;
            this.grpboxKarte.Text = "Karte";
            // 
            // btnSucheStaton
            // 
            this.btnSucheStaton.Location = new System.Drawing.Point(129, 17);
            this.btnSucheStaton.Name = "btnSucheStaton";
            this.btnSucheStaton.Size = new System.Drawing.Size(170, 45);
            this.btnSucheStaton.TabIndex = 5;
            this.btnSucheStaton.Text = "Suche Station";
            this.btnSucheStaton.UseVisualStyleBackColor = true;
            this.btnSucheStaton.Click += new System.EventHandler(this.btnSucheStaton_Click);
            // 
            // txtboxstation
            // 
            this.txtboxstation.Location = new System.Drawing.Point(7, 26);
            this.txtboxstation.Name = "txtboxstation";
            this.txtboxstation.Size = new System.Drawing.Size(116, 26);
            this.txtboxstation.TabIndex = 4;
            // 
            // gmapKarte
            // 
            this.gmapKarte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmapKarte.Bearing = 0F;
            this.gmapKarte.CanDragMap = true;
            this.gmapKarte.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapKarte.GrayScaleMode = false;
            this.gmapKarte.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapKarte.LevelsKeepInMemmory = 5;
            this.gmapKarte.Location = new System.Drawing.Point(6, 76);
            this.gmapKarte.MarkersEnabled = true;
            this.gmapKarte.MaxZoom = 2;
            this.gmapKarte.MinZoom = 2;
            this.gmapKarte.MouseWheelZoomEnabled = true;
            this.gmapKarte.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapKarte.Name = "gmapKarte";
            this.gmapKarte.NegativeMode = false;
            this.gmapKarte.PolygonsEnabled = true;
            this.gmapKarte.RetryLoadTile = 0;
            this.gmapKarte.RoutesEnabled = true;
            this.gmapKarte.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapKarte.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapKarte.ShowTileGridLines = false;
            this.gmapKarte.Size = new System.Drawing.Size(660, 244);
            this.gmapKarte.TabIndex = 10;
            this.gmapKarte.Zoom = 0D;
            // 
            // Karte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpboxKarte);
            this.Controls.Add(this.grpboxmenue);
            this.Name = "Karte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karte";
            this.grpboxmenue.ResumeLayout(false);
            this.grpboxKarte.ResumeLayout(false);
            this.grpboxKarte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxmenue;
        private System.Windows.Forms.Button btnVerbindungen;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpboxKarte;
        private GMap.NET.WindowsForms.GMapControl gmapKarte;
        private System.Windows.Forms.Button btnSucheStaton;
        private System.Windows.Forms.TextBox txtboxstation;
    }
}