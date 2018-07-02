namespace projektwoche2018_v2
{
    partial class FormOeffnen
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
            this.comboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.buttonOeffnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDatabase
            // 
            this.comboBoxDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatabase.FormattingEnabled = true;
            this.comboBoxDatabase.Location = new System.Drawing.Point(59, 38);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(147, 21);
            this.comboBoxDatabase.TabIndex = 0;
            // 
            // buttonOeffnen
            // 
            this.buttonOeffnen.Location = new System.Drawing.Point(70, 155);
            this.buttonOeffnen.Name = "buttonOeffnen";
            this.buttonOeffnen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOeffnen.Size = new System.Drawing.Size(114, 23);
            this.buttonOeffnen.TabIndex = 1;
            this.buttonOeffnen.Text = "Öffnen";
            this.buttonOeffnen.UseVisualStyleBackColor = true;
            this.buttonOeffnen.Click += new System.EventHandler(this.buttonOeffnen_Click);
            // 
            // FormOeffnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonOeffnen);
            this.Controls.Add(this.comboBoxDatabase);
            this.Name = "FormOeffnen";
            this.Text = "FormOeffnen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDatabase;
        private System.Windows.Forms.Button buttonOeffnen;
    }
}