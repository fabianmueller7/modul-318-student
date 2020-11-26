
namespace MyTransportApp
{
    partial class Gespeichert
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
            this.grpboxMenue = new System.Windows.Forms.GroupBox();
            this.btnGespeichert = new System.Windows.Forms.Button();
            this.btnNaechsteStation = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.grpboxGespeichert = new System.Windows.Forms.GroupBox();
            this.grpboxMenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxMenue
            // 
            this.grpboxMenue.Controls.Add(this.btnGespeichert);
            this.grpboxMenue.Controls.Add(this.btnNaechsteStation);
            this.grpboxMenue.Controls.Add(this.btnKarte);
            this.grpboxMenue.Controls.Add(this.btnAbfahrtstafel);
            this.grpboxMenue.Controls.Add(this.btnVerbindungen);
            this.grpboxMenue.Location = new System.Drawing.Point(48, 13);
            this.grpboxMenue.Name = "grpboxMenue";
            this.grpboxMenue.Size = new System.Drawing.Size(685, 69);
            this.grpboxMenue.TabIndex = 0;
            this.grpboxMenue.TabStop = false;
            this.grpboxMenue.Text = "Menü";
            // 
            // btnGespeichert
            // 
            this.btnGespeichert.Enabled = false;
            this.btnGespeichert.Location = new System.Drawing.Point(553, 26);
            this.btnGespeichert.Name = "btnGespeichert";
            this.btnGespeichert.Size = new System.Drawing.Size(126, 36);
            this.btnGespeichert.TabIndex = 4;
            this.btnGespeichert.Text = "Gespeichert";
            this.btnGespeichert.UseVisualStyleBackColor = true;
            // 
            // btnNaechsteStation
            // 
            this.btnNaechsteStation.Location = new System.Drawing.Point(405, 26);
            this.btnNaechsteStation.Name = "btnNaechsteStation";
            this.btnNaechsteStation.Size = new System.Drawing.Size(142, 37);
            this.btnNaechsteStation.TabIndex = 3;
            this.btnNaechsteStation.Text = "Nächste Station";
            this.btnNaechsteStation.UseVisualStyleBackColor = true;
            this.btnNaechsteStation.Click += new System.EventHandler(this.btnNaechsteStation_Click);
            // 
            // btnKarte
            // 
            this.btnKarte.Location = new System.Drawing.Point(272, 26);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(127, 37);
            this.btnKarte.TabIndex = 2;
            this.btnKarte.Text = "Karte";
            this.btnKarte.UseVisualStyleBackColor = true;
            this.btnKarte.Click += new System.EventHandler(this.btnKarte_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(139, 26);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(127, 37);
            this.btnAbfahrtstafel.TabIndex = 1;
            this.btnAbfahrtstafel.Text = "Abfahrstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Location = new System.Drawing.Point(6, 25);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(127, 37);
            this.btnVerbindungen.TabIndex = 0;
            this.btnVerbindungen.Text = "Verbindungen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // grpboxGespeichert
            // 
            this.grpboxGespeichert.Location = new System.Drawing.Point(48, 120);
            this.grpboxGespeichert.Name = "grpboxGespeichert";
            this.grpboxGespeichert.Size = new System.Drawing.Size(685, 318);
            this.grpboxGespeichert.TabIndex = 1;
            this.grpboxGespeichert.TabStop = false;
            this.grpboxGespeichert.Text = "Gespeichert";
            // 
            // Gespeichert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpboxGespeichert);
            this.Controls.Add(this.grpboxMenue);
            this.Name = "Gespeichert";
            this.Text = "Gespeichert";
            this.grpboxMenue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxMenue;
        private System.Windows.Forms.Button btnVerbindungen;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnNaechsteStation;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.Button btnGespeichert;
        private System.Windows.Forms.GroupBox grpboxGespeichert;
    }
}