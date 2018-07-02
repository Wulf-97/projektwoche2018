namespace projektwoche2018_v2.UserControls
{
    partial class UserControlEinstellungen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.textBoxPWD = new System.Windows.Forms.TextBox();
            this.textBoxDB = new System.Windows.Forms.TextBox();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datenbank";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(173, 52);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(100, 20);
            this.textBoxServer.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(173, 114);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUID.TabIndex = 5;
            // 
            // textBoxPWD
            // 
            this.textBoxPWD.Location = new System.Drawing.Point(173, 182);
            this.textBoxPWD.Name = "textBoxPWD";
            this.textBoxPWD.Size = new System.Drawing.Size(100, 20);
            this.textBoxPWD.TabIndex = 6;
            // 
            // textBoxDB
            // 
            this.textBoxDB.Location = new System.Drawing.Point(173, 248);
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Size = new System.Drawing.Size(100, 20);
            this.textBoxDB.TabIndex = 7;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(47, 336);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 8;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // UserControlEinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.textBoxDB);
            this.Controls.Add(this.textBoxPWD);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlEinstellungen";
            this.Size = new System.Drawing.Size(341, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonSpeichern;
        public System.Windows.Forms.TextBox textBoxServer;
        public System.Windows.Forms.TextBox textBoxUID;
        public System.Windows.Forms.TextBox textBoxPWD;
        public System.Windows.Forms.TextBox textBoxDB;
    }
}
