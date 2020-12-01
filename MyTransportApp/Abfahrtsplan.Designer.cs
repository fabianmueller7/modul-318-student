
namespace MyTransportApp
{
    partial class Abfahrtsplan
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
            this.btnNaechStestation = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.grpboxabfahrtstafel = new System.Windows.Forms.GroupBox();
            this.dtagridAbfahrtstagel = new System.Windows.Forms.DataGridView();
            this.columnnach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnenummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.txtboxstation = new System.Windows.Forms.TextBox();
            this.lblstation = new System.Windows.Forms.Label();
            this.grpboxmenue.SuspendLayout();
            this.grpboxabfahrtstafel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridAbfahrtstagel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxmenue
            // 
            this.grpboxmenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxmenue.Controls.Add(this.btnGespeichert);
            this.grpboxmenue.Controls.Add(this.btnNaechStestation);
            this.grpboxmenue.Controls.Add(this.btnKarte);
            this.grpboxmenue.Controls.Add(this.btnAbfahrtstafel);
            this.grpboxmenue.Controls.Add(this.btnVerbindungen);
            this.grpboxmenue.Location = new System.Drawing.Point(48, 13);
            this.grpboxmenue.Name = "grpboxmenue";
            this.grpboxmenue.Size = new System.Drawing.Size(691, 77);
            this.grpboxmenue.TabIndex = 0;
            this.grpboxmenue.TabStop = false;
            this.grpboxmenue.Text = "Menü";
            // 
            // btnGespeichert
            // 
            this.btnGespeichert.Location = new System.Drawing.Point(550, 25);
            this.btnGespeichert.Name = "btnGespeichert";
            this.btnGespeichert.Size = new System.Drawing.Size(135, 42);
            this.btnGespeichert.TabIndex = 4;
            this.btnGespeichert.Text = "Gespeichert";
            this.btnGespeichert.UseVisualStyleBackColor = true;
            this.btnGespeichert.Click += new System.EventHandler(this.btnGespeichert_Click);
            // 
            // btnNaechStestation
            // 
            this.btnNaechStestation.Location = new System.Drawing.Point(405, 26);
            this.btnNaechStestation.Name = "btnNaechStestation";
            this.btnNaechStestation.Size = new System.Drawing.Size(139, 42);
            this.btnNaechStestation.TabIndex = 3;
            this.btnNaechStestation.Text = "Nächste Station";
            this.btnNaechStestation.UseVisualStyleBackColor = true;
            this.btnNaechStestation.Click += new System.EventHandler(this.btnNaechStestation_Click);
            // 
            // btnKarte
            // 
            this.btnKarte.Location = new System.Drawing.Point(275, 25);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(124, 42);
            this.btnKarte.TabIndex = 2;
            this.btnKarte.Text = "Karte";
            this.btnKarte.UseVisualStyleBackColor = true;
            this.btnKarte.Click += new System.EventHandler(this.btnKarte_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAbfahrtstafel.Enabled = false;
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(145, 25);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(124, 42);
            this.btnAbfahrtstafel.TabIndex = 1;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = false;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Location = new System.Drawing.Point(6, 25);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(133, 43);
            this.btnVerbindungen.TabIndex = 0;
            this.btnVerbindungen.Text = "Verbindungen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // grpboxabfahrtstafel
            // 
            this.grpboxabfahrtstafel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxabfahrtstafel.Controls.Add(this.dtagridAbfahrtstagel);
            this.grpboxabfahrtstafel.Controls.Add(this.btnsuchen);
            this.grpboxabfahrtstafel.Controls.Add(this.txtboxstation);
            this.grpboxabfahrtstafel.Controls.Add(this.lblstation);
            this.grpboxabfahrtstafel.Location = new System.Drawing.Point(48, 112);
            this.grpboxabfahrtstafel.Name = "grpboxabfahrtstafel";
            this.grpboxabfahrtstafel.Size = new System.Drawing.Size(691, 326);
            this.grpboxabfahrtstafel.TabIndex = 1;
            this.grpboxabfahrtstafel.TabStop = false;
            this.grpboxabfahrtstafel.Text = "Abfahrtstafel";
            // 
            // dtagridAbfahrtstagel
            // 
            this.dtagridAbfahrtstagel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtagridAbfahrtstagel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagridAbfahrtstagel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnnach,
            this.columnenummer,
            this.colmnname});
            this.dtagridAbfahrtstagel.Location = new System.Drawing.Point(7, 84);
            this.dtagridAbfahrtstagel.Name = "dtagridAbfahrtstagel";
            this.dtagridAbfahrtstagel.RowHeadersWidth = 62;
            this.dtagridAbfahrtstagel.RowTemplate.Height = 28;
            this.dtagridAbfahrtstagel.Size = new System.Drawing.Size(678, 236);
            this.dtagridAbfahrtstagel.TabIndex = 4;
            // 
            // columnnach
            // 
            this.columnnach.HeaderText = "Nach";
            this.columnnach.MinimumWidth = 8;
            this.columnnach.Name = "columnnach";
            this.columnnach.ReadOnly = true;
            this.columnnach.Width = 150;
            // 
            // columnenummer
            // 
            this.columnenummer.HeaderText = "Nummer";
            this.columnenummer.MinimumWidth = 8;
            this.columnenummer.Name = "columnenummer";
            this.columnenummer.ReadOnly = true;
            this.columnenummer.Width = 150;
            // 
            // colmnname
            // 
            this.colmnname.HeaderText = "Name";
            this.colmnname.MinimumWidth = 8;
            this.colmnname.Name = "colmnname";
            this.colmnname.Width = 150;
            // 
            // btnsuchen
            // 
            this.btnsuchen.Location = new System.Drawing.Point(539, 35);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(102, 30);
            this.btnsuchen.TabIndex = 3;
            this.btnsuchen.Text = "Suchen";
            this.btnsuchen.UseVisualStyleBackColor = true;
            this.btnsuchen.Click += new System.EventHandler(this.btnsuchen_Click);
            // 
            // txtboxstation
            // 
            this.txtboxstation.Location = new System.Drawing.Point(85, 34);
            this.txtboxstation.Name = "txtboxstation";
            this.txtboxstation.Size = new System.Drawing.Size(100, 26);
            this.txtboxstation.TabIndex = 1;
            // 
            // lblstation
            // 
            this.lblstation.AutoSize = true;
            this.lblstation.Location = new System.Drawing.Point(19, 35);
            this.lblstation.Name = "lblstation";
            this.lblstation.Size = new System.Drawing.Size(60, 20);
            this.lblstation.TabIndex = 0;
            this.lblstation.Text = "Station";
            // 
            // Abfahrtsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpboxabfahrtstafel);
            this.Controls.Add(this.grpboxmenue);
            this.Name = "Abfahrtsplan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abfahrtsplan";
            this.grpboxmenue.ResumeLayout(false);
            this.grpboxabfahrtstafel.ResumeLayout(false);
            this.grpboxabfahrtstafel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridAbfahrtstagel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxmenue;
        private System.Windows.Forms.Button btnVerbindungen;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.Button btnNaechStestation;
        private System.Windows.Forms.Button btnGespeichert;
        private System.Windows.Forms.GroupBox grpboxabfahrtstafel;
        private System.Windows.Forms.TextBox txtboxstation;
        private System.Windows.Forms.Label lblstation;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.DataGridView dtagridAbfahrtstagel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnnach;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnenummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmnname;
    }
}