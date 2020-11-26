
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
            this.btnGespeichert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.grpboxKarte = new System.Windows.Forms.GroupBox();
            this.grpboxmenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxmenue
            // 
            this.grpboxmenue.Controls.Add(this.btnGespeichert);
            this.grpboxmenue.Controls.Add(this.button1);
            this.grpboxmenue.Controls.Add(this.btnKarte);
            this.grpboxmenue.Controls.Add(this.btnAbfahrtstafel);
            this.grpboxmenue.Controls.Add(this.btnVerbindungen);
            this.grpboxmenue.Location = new System.Drawing.Point(34, 12);
            this.grpboxmenue.Name = "grpboxmenue";
            this.grpboxmenue.Size = new System.Drawing.Size(692, 76);
            this.grpboxmenue.TabIndex = 0;
            this.grpboxmenue.TabStop = false;
            this.grpboxmenue.Text = "Menü";
            // 
            // btnGespeichert
            // 
            this.btnGespeichert.Location = new System.Drawing.Point(562, 25);
            this.btnGespeichert.Name = "btnGespeichert";
            this.btnGespeichert.Size = new System.Drawing.Size(123, 38);
            this.btnGespeichert.TabIndex = 3;
            this.btnGespeichert.Text = "Gespeichert";
            this.btnGespeichert.UseVisualStyleBackColor = true;
            this.btnGespeichert.Click += new System.EventHandler(this.btnGespeichert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 1;
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
            this.grpboxKarte.Location = new System.Drawing.Point(49, 142);
            this.grpboxKarte.Name = "grpboxKarte";
            this.grpboxKarte.Size = new System.Drawing.Size(677, 296);
            this.grpboxKarte.TabIndex = 1;
            this.grpboxKarte.TabStop = false;
            this.grpboxKarte.Text = "Karte";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxmenue;
        private System.Windows.Forms.Button btnVerbindungen;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGespeichert;
        private System.Windows.Forms.GroupBox grpboxKarte;
    }
}