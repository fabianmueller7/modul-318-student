
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
            this.btnNaechsteStation = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.grpboxNaechsteStation = new System.Windows.Forms.GroupBox();
            this.dgvNaechsteStation = new System.Windows.Forms.DataGridView();
            this.columnstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columndistanz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpboxmenue.SuspendLayout();
            this.grpboxNaechsteStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaechsteStation)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxmenue
            // 
            this.grpboxmenue.Controls.Add(this.btnNaechsteStation);
            this.grpboxmenue.Controls.Add(this.btnKarte);
            this.grpboxmenue.Controls.Add(this.btnAbfahrtstafel);
            this.grpboxmenue.Controls.Add(this.btnVerbindungen);
            this.grpboxmenue.Location = new System.Drawing.Point(49, 13);
            this.grpboxmenue.Name = "grpboxmenue";
            this.grpboxmenue.Size = new System.Drawing.Size(695, 71);
            this.grpboxmenue.TabIndex = 12;
            this.grpboxmenue.TabStop = false;
            this.grpboxmenue.Text = "Menü";
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
            this.grpboxNaechsteStation.Controls.Add(this.dgvNaechsteStation);
            this.grpboxNaechsteStation.Location = new System.Drawing.Point(49, 125);
            this.grpboxNaechsteStation.Name = "grpboxNaechsteStation";
            this.grpboxNaechsteStation.Size = new System.Drawing.Size(682, 313);
            this.grpboxNaechsteStation.TabIndex = 11;
            this.grpboxNaechsteStation.TabStop = false;
            this.grpboxNaechsteStation.Text = "Nächste Station";
            // 
            // dgvNaechsteStation
            // 
            this.dgvNaechsteStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaechsteStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnstation,
            this.columndistanz});
            this.dgvNaechsteStation.Location = new System.Drawing.Point(10, 25);
            this.dgvNaechsteStation.Name = "dgvNaechsteStation";
            this.dgvNaechsteStation.RowHeadersWidth = 62;
            this.dgvNaechsteStation.RowTemplate.Height = 28;
            this.dgvNaechsteStation.Size = new System.Drawing.Size(666, 282);
            this.dgvNaechsteStation.TabIndex = 10;
            // 
            // columnstation
            // 
            this.columnstation.HeaderText = "Station";
            this.columnstation.MinimumWidth = 8;
            this.columnstation.Name = "columnstation";
            this.columnstation.ReadOnly = true;
            this.columnstation.Width = 150;
            // 
            // columndistanz
            // 
            this.columndistanz.HeaderText = "Dinstanz";
            this.columndistanz.MinimumWidth = 8;
            this.columndistanz.Name = "columndistanz";
            this.columndistanz.ReadOnly = true;
            this.columndistanz.Width = 150;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaechsteStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxmenue;
        private System.Windows.Forms.Button btnNaechsteStation;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnVerbindungen;
        private System.Windows.Forms.GroupBox grpboxNaechsteStation;
        private System.Windows.Forms.DataGridView dgvNaechsteStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columndistanz;
    }
}