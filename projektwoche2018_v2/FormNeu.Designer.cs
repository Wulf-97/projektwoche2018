namespace projektwoche2018_v2
{
    partial class FormNeu
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonErstellen = new System.Windows.Forms.Button();
            this.textboxdatenbank = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datenbankname";
            // 
            // buttonErstellen
            // 
            this.buttonErstellen.Location = new System.Drawing.Point(104, 118);
            this.buttonErstellen.Name = "buttonErstellen";
            this.buttonErstellen.Size = new System.Drawing.Size(75, 23);
            this.buttonErstellen.TabIndex = 4;
            this.buttonErstellen.Text = "erstellen";
            this.buttonErstellen.UseVisualStyleBackColor = true;
            // 
            // textboxdatenbank
            // 
            this.textboxdatenbank.Location = new System.Drawing.Point(55, 78);
            this.textboxdatenbank.Name = "textboxdatenbank";
            this.textboxdatenbank.Size = new System.Drawing.Size(175, 20);
            this.textboxdatenbank.TabIndex = 3;
            // 
            // FormNeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonErstellen);
            this.Controls.Add(this.textboxdatenbank);
            this.Name = "FormNeu";
            this.Text = "FormNeu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonErstellen;
        public System.Windows.Forms.TextBox textboxdatenbank;
    }
}