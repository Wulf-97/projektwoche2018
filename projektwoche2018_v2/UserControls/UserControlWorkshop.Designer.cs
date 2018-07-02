namespace projektwoche2018_v2.UserControls
{
    partial class UserControlWorkshop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxWorkshops = new System.Windows.Forms.ListBox();
            this.buttonNeu = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNr = new System.Windows.Forms.TextBox();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.textBoxBeschreibung = new System.Windows.Forms.TextBox();
            this.textBoxKosten = new System.Windows.Forms.TextBox();
            this.textBoxVoraussetzungen = new System.Windows.Forms.TextBox();
            this.textBoxTeilMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxSchwerpunkt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxWorkshops
            // 
            this.listBoxWorkshops.FormattingEnabled = true;
            this.listBoxWorkshops.Location = new System.Drawing.Point(12, 16);
            this.listBoxWorkshops.Name = "listBoxWorkshops";
            this.listBoxWorkshops.Size = new System.Drawing.Size(175, 264);
            this.listBoxWorkshops.TabIndex = 0;
            this.listBoxWorkshops.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkshops_SelectedIndexChanged);
            // 
            // buttonNeu
            // 
            this.buttonNeu.Location = new System.Drawing.Point(12, 306);
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(75, 23);
            this.buttonNeu.TabIndex = 1;
            this.buttonNeu.Text = "Neu";
            this.buttonNeu.UseVisualStyleBackColor = true;
            this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(12, 361);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 2;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(770, 379);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 3;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beschreibung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kosten";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Voraussetzungen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Teilnehmer min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Teilnehmer max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(742, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Schwerpunkt";
            // 
            // textBoxNr
            // 
            this.textBoxNr.Location = new System.Drawing.Point(210, 61);
            this.textBoxNr.Name = "textBoxNr";
            this.textBoxNr.Size = new System.Drawing.Size(100, 20);
            this.textBoxNr.TabIndex = 12;
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(367, 61);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(478, 20);
            this.textBoxTitel.TabIndex = 13;
            // 
            // textBoxBeschreibung
            // 
            this.textBoxBeschreibung.Location = new System.Drawing.Point(210, 148);
            this.textBoxBeschreibung.Multiline = true;
            this.textBoxBeschreibung.Name = "textBoxBeschreibung";
            this.textBoxBeschreibung.Size = new System.Drawing.Size(635, 80);
            this.textBoxBeschreibung.TabIndex = 14;
            // 
            // textBoxKosten
            // 
            this.textBoxKosten.Location = new System.Drawing.Point(210, 280);
            this.textBoxKosten.Name = "textBoxKosten";
            this.textBoxKosten.Size = new System.Drawing.Size(100, 20);
            this.textBoxKosten.TabIndex = 15;
            // 
            // textBoxVoraussetzungen
            // 
            this.textBoxVoraussetzungen.Location = new System.Drawing.Point(367, 280);
            this.textBoxVoraussetzungen.Name = "textBoxVoraussetzungen";
            this.textBoxVoraussetzungen.Size = new System.Drawing.Size(100, 20);
            this.textBoxVoraussetzungen.TabIndex = 16;
            // 
            // textBoxTeilMin
            // 
            this.textBoxTeilMin.Location = new System.Drawing.Point(494, 280);
            this.textBoxTeilMin.Name = "textBoxTeilMin";
            this.textBoxTeilMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeilMin.TabIndex = 17;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(622, 280);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 18;
            // 
            // textBoxSchwerpunkt
            // 
            this.textBoxSchwerpunkt.Location = new System.Drawing.Point(745, 280);
            this.textBoxSchwerpunkt.Name = "textBoxSchwerpunkt";
            this.textBoxSchwerpunkt.Size = new System.Drawing.Size(100, 20);
            this.textBoxSchwerpunkt.TabIndex = 19;
            // 
            // UserControlWorkshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSchwerpunkt);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxTeilMin);
            this.Controls.Add(this.textBoxVoraussetzungen);
            this.Controls.Add(this.textBoxKosten);
            this.Controls.Add(this.textBoxBeschreibung);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.textBoxNr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonNeu);
            this.Controls.Add(this.listBoxWorkshops);
            this.Name = "UserControlWorkshop";
            this.Size = new System.Drawing.Size(877, 432);
            this.Load += new System.EventHandler(this.UserControlWorkshop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorkshops;
        private System.Windows.Forms.Button buttonNeu;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNr;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.TextBox textBoxBeschreibung;
        private System.Windows.Forms.TextBox textBoxKosten;
        private System.Windows.Forms.TextBox textBoxVoraussetzungen;
        private System.Windows.Forms.TextBox textBoxTeilMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxSchwerpunkt;
    }
}
