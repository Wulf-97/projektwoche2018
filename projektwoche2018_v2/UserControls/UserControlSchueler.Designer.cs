namespace projektwoche2018_v2.UserControls
{
    partial class UserControlSchueler
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
            this.listBoxSchueler = new System.Windows.Forms.ListBox();
            this.buttonNeu = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxSchule = new System.Windows.Forms.TextBox();
            this.textBoxLehrkraft = new System.Windows.Forms.TextBox();
            this.comboBoxKlasse = new System.Windows.Forms.ComboBox();
            this.comboBoxAbschluss = new System.Windows.Forms.ComboBox();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSchueler
            // 
            this.listBoxSchueler.FormattingEnabled = true;
            this.listBoxSchueler.Location = new System.Drawing.Point(17, 14);
            this.listBoxSchueler.Name = "listBoxSchueler";
            this.listBoxSchueler.Size = new System.Drawing.Size(228, 277);
            this.listBoxSchueler.TabIndex = 0;
            this.listBoxSchueler.SelectedIndexChanged += new System.EventHandler(this.listBoxSchueler_SelectedIndexChanged);
            // 
            // buttonNeu
            // 
            this.buttonNeu.Location = new System.Drawing.Point(17, 313);
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(75, 23);
            this.buttonNeu.TabIndex = 1;
            this.buttonNeu.Text = "Neu";
            this.buttonNeu.UseVisualStyleBackColor = true;
            this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(170, 313);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 2;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Klasse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "voraussichtlicher Abschluss";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Schule";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Betreunde Lehrkraft";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(441, 33);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(100, 20);
            this.textBoxVorname.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(441, 103);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 11;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(441, 68);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(100, 20);
            this.textBoxNachname.TabIndex = 12;
            // 
            // textBoxSchule
            // 
            this.textBoxSchule.Location = new System.Drawing.Point(441, 233);
            this.textBoxSchule.Name = "textBoxSchule";
            this.textBoxSchule.Size = new System.Drawing.Size(100, 20);
            this.textBoxSchule.TabIndex = 13;
            // 
            // textBoxLehrkraft
            // 
            this.textBoxLehrkraft.Location = new System.Drawing.Point(441, 278);
            this.textBoxLehrkraft.Name = "textBoxLehrkraft";
            this.textBoxLehrkraft.Size = new System.Drawing.Size(100, 20);
            this.textBoxLehrkraft.TabIndex = 14;
            // 
            // comboBoxKlasse
            // 
            this.comboBoxKlasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKlasse.FormattingEnabled = true;
            this.comboBoxKlasse.Location = new System.Drawing.Point(431, 141);
            this.comboBoxKlasse.Name = "comboBoxKlasse";
            this.comboBoxKlasse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKlasse.TabIndex = 15;
            // 
            // comboBoxAbschluss
            // 
            this.comboBoxAbschluss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAbschluss.FormattingEnabled = true;
            this.comboBoxAbschluss.Location = new System.Drawing.Point(431, 186);
            this.comboBoxAbschluss.Name = "comboBoxAbschluss";
            this.comboBoxAbschluss.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAbschluss.TabIndex = 16;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(441, 312);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 17;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // UserControlSchueler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.comboBoxAbschluss);
            this.Controls.Add(this.comboBoxKlasse);
            this.Controls.Add(this.textBoxLehrkraft);
            this.Controls.Add(this.textBoxSchule);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonNeu);
            this.Controls.Add(this.listBoxSchueler);
            this.Name = "UserControlSchueler";
            this.Size = new System.Drawing.Size(633, 362);
            this.Load += new System.EventHandler(this.UserControlSchueler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSchueler;
        private System.Windows.Forms.Button buttonNeu;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxSchule;
        private System.Windows.Forms.TextBox textBoxLehrkraft;
        private System.Windows.Forms.ComboBox comboBoxKlasse;
        private System.Windows.Forms.ComboBox comboBoxAbschluss;
        private System.Windows.Forms.Button buttonSpeichern;
    }
}
