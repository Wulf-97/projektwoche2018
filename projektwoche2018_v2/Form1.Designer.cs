namespace projektwoche2018_v2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleSchülerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einzelneSchülerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleWorkshopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einzelneWorkshopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkshopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schülerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wahlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.ansichtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alleSchülerToolStripMenuItem,
            this.einzelneSchülerToolStripMenuItem,
            this.alleWorkshopsToolStripMenuItem,
            this.einzelneWorkshopsToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // alleSchülerToolStripMenuItem
            // 
            this.alleSchülerToolStripMenuItem.Name = "alleSchülerToolStripMenuItem";
            this.alleSchülerToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.alleSchülerToolStripMenuItem.Text = "Alle Schüler";
            // 
            // einzelneSchülerToolStripMenuItem
            // 
            this.einzelneSchülerToolStripMenuItem.Name = "einzelneSchülerToolStripMenuItem";
            this.einzelneSchülerToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.einzelneSchülerToolStripMenuItem.Text = "Einzelne Schüler";
            // 
            // alleWorkshopsToolStripMenuItem
            // 
            this.alleWorkshopsToolStripMenuItem.Name = "alleWorkshopsToolStripMenuItem";
            this.alleWorkshopsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.alleWorkshopsToolStripMenuItem.Text = "Alle Workshops";
            // 
            // einzelneWorkshopsToolStripMenuItem
            // 
            this.einzelneWorkshopsToolStripMenuItem.Name = "einzelneWorkshopsToolStripMenuItem";
            this.einzelneWorkshopsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.einzelneWorkshopsToolStripMenuItem.Text = "Einzelne Workshops";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkshopToolStripMenuItem,
            this.schülerToolStripMenuItem1,
            this.wahlToolStripMenuItem});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // WorkshopToolStripMenuItem
            // 
            this.WorkshopToolStripMenuItem.Name = "WorkshopToolStripMenuItem";
            this.WorkshopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.WorkshopToolStripMenuItem.Text = "Workshop";
            this.WorkshopToolStripMenuItem.Click += new System.EventHandler(this.WorkshopToolStripMenuItem_Click);
            // 
            // schülerToolStripMenuItem1
            // 
            this.schülerToolStripMenuItem1.Name = "schülerToolStripMenuItem1";
            this.schülerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.schülerToolStripMenuItem1.Text = "Schüler";
            this.schülerToolStripMenuItem1.Click += new System.EventHandler(this.schülerToolStripMenuItem1_Click);
            // 
            // wahlToolStripMenuItem
            // 
            this.wahlToolStripMenuItem.Name = "wahlToolStripMenuItem";
            this.wahlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wahlToolStripMenuItem.Text = "Wahl";
            this.wahlToolStripMenuItem.Click += new System.EventHandler(this.wahlToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 475);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 514);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Projektwoche2018";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleSchülerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einzelneSchülerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleWorkshopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einzelneWorkshopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkshopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schülerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wahlToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

