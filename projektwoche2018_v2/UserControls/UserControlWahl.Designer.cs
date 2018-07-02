namespace projektwoche2018_v2.UserControls
{
    partial class UserControlWahl
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
            this.listBoxWahl = new System.Windows.Forms.ListBox();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.labelWorkshop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWorkshop1 = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkshop2 = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkshop3 = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkshop4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxWahl
            // 
            this.listBoxWahl.FormattingEnabled = true;
            this.listBoxWahl.Location = new System.Drawing.Point(20, 3);
            this.listBoxWahl.Name = "listBoxWahl";
            this.listBoxWahl.Size = new System.Drawing.Size(427, 212);
            this.listBoxWahl.TabIndex = 0;
            this.listBoxWahl.SelectedIndexChanged += new System.EventHandler(this.listBoxWahl_SelectedIndexChanged);
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(170, 426);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 1;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // labelWorkshop
            // 
            this.labelWorkshop.AutoSize = true;
            this.labelWorkshop.Location = new System.Drawing.Point(23, 260);
            this.labelWorkshop.Name = "labelWorkshop";
            this.labelWorkshop.Size = new System.Drawing.Size(62, 13);
            this.labelWorkshop.TabIndex = 2;
            this.labelWorkshop.Text = "Workshop1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Workshop2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Workshop3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Workshop4";
            // 
            // comboBoxWorkshop1
            // 
            this.comboBoxWorkshop1.FormattingEnabled = true;
            this.comboBoxWorkshop1.Location = new System.Drawing.Point(105, 257);
            this.comboBoxWorkshop1.Name = "comboBoxWorkshop1";
            this.comboBoxWorkshop1.Size = new System.Drawing.Size(342, 21);
            this.comboBoxWorkshop1.TabIndex = 6;
            // 
            // comboBoxWorkshop2
            // 
            this.comboBoxWorkshop2.FormattingEnabled = true;
            this.comboBoxWorkshop2.Location = new System.Drawing.Point(105, 300);
            this.comboBoxWorkshop2.Name = "comboBoxWorkshop2";
            this.comboBoxWorkshop2.Size = new System.Drawing.Size(342, 21);
            this.comboBoxWorkshop2.TabIndex = 7;
            // 
            // comboBoxWorkshop3
            // 
            this.comboBoxWorkshop3.FormattingEnabled = true;
            this.comboBoxWorkshop3.Location = new System.Drawing.Point(105, 345);
            this.comboBoxWorkshop3.Name = "comboBoxWorkshop3";
            this.comboBoxWorkshop3.Size = new System.Drawing.Size(342, 21);
            this.comboBoxWorkshop3.TabIndex = 8;
            // 
            // comboBoxWorkshop4
            // 
            this.comboBoxWorkshop4.FormattingEnabled = true;
            this.comboBoxWorkshop4.Location = new System.Drawing.Point(105, 385);
            this.comboBoxWorkshop4.Name = "comboBoxWorkshop4";
            this.comboBoxWorkshop4.Size = new System.Drawing.Size(342, 21);
            this.comboBoxWorkshop4.TabIndex = 9;
            // 
            // UserControlWahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxWorkshop4);
            this.Controls.Add(this.comboBoxWorkshop3);
            this.Controls.Add(this.comboBoxWorkshop2);
            this.Controls.Add(this.comboBoxWorkshop1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWorkshop);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.listBoxWahl);
            this.Name = "UserControlWahl";
            this.Size = new System.Drawing.Size(467, 478);
            this.Load += new System.EventHandler(this.UserControlWahl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWahl;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Label labelWorkshop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWorkshop1;
        private System.Windows.Forms.ComboBox comboBoxWorkshop2;
        private System.Windows.Forms.ComboBox comboBoxWorkshop3;
        private System.Windows.Forms.ComboBox comboBoxWorkshop4;
    }
}
