namespace PROIECT_PAW
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
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaretxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporttxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anulareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPariaza = new System.Windows.Forms.Button();
            this.treeViewMeciuri = new System.Windows.Forms.TreeView();
            this.btnVizualizeazaMeciuri = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGolesteTreeView = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.exporttxtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1327, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareXMLToolStripMenuItem,
            this.deserializareXMLToolStripMenuItem,
            this.salvaretxtToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.serializareToolStripMenuItem.Text = "Fisier";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // serializareXMLToolStripMenuItem
            // 
            this.serializareXMLToolStripMenuItem.Name = "serializareXMLToolStripMenuItem";
            this.serializareXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializareXMLToolStripMenuItem.Text = "Serializare XML";
            this.serializareXMLToolStripMenuItem.Click += new System.EventHandler(this.serializareXMLToolStripMenuItem_Click);
            // 
            // deserializareXMLToolStripMenuItem
            // 
            this.deserializareXMLToolStripMenuItem.Name = "deserializareXMLToolStripMenuItem";
            this.deserializareXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializareXMLToolStripMenuItem.Text = "Deserializare XML";
            this.deserializareXMLToolStripMenuItem.Click += new System.EventHandler(this.deserializareXMLToolStripMenuItem_Click);
            // 
            // salvaretxtToolStripMenuItem
            // 
            this.salvaretxtToolStripMenuItem.Name = "salvaretxtToolStripMenuItem";
            this.salvaretxtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvaretxtToolStripMenuItem.Text = "Salvare (*txt)";
            this.salvaretxtToolStripMenuItem.Click += new System.EventHandler(this.salvaretxtToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // exporttxtToolStripMenuItem
            // 
            this.exporttxtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anulareToolStripMenuItem});
            this.exporttxtToolStripMenuItem.Name = "exporttxtToolStripMenuItem";
            this.exporttxtToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.exporttxtToolStripMenuItem.Text = "Editare";
            this.exporttxtToolStripMenuItem.Click += new System.EventHandler(this.exporttxtToolStripMenuItem_Click);
            // 
            // anulareToolStripMenuItem
            // 
            this.anulareToolStripMenuItem.Name = "anulareToolStripMenuItem";
            this.anulareToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.anulareToolStripMenuItem.Text = "Anulare";
            // 
            // btnPariaza
            // 
            this.btnPariaza.BackColor = System.Drawing.Color.Red;
            this.btnPariaza.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPariaza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPariaza.Location = new System.Drawing.Point(26, 365);
            this.btnPariaza.Name = "btnPariaza";
            this.btnPariaza.Size = new System.Drawing.Size(124, 55);
            this.btnPariaza.TabIndex = 1;
            this.btnPariaza.Text = "Pariaza!";
            this.btnPariaza.UseVisualStyleBackColor = false;
            this.btnPariaza.Click += new System.EventHandler(this.btnPariaza_Click);
            // 
            // treeViewMeciuri
            // 
            this.treeViewMeciuri.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewMeciuri.Location = new System.Drawing.Point(26, 107);
            this.treeViewMeciuri.Name = "treeViewMeciuri";
            this.treeViewMeciuri.Size = new System.Drawing.Size(433, 228);
            this.treeViewMeciuri.TabIndex = 3;
            this.treeViewMeciuri.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMeciuri_AfterSelect);
            // 
            // btnVizualizeazaMeciuri
            // 
            this.btnVizualizeazaMeciuri.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnVizualizeazaMeciuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVizualizeazaMeciuri.Location = new System.Drawing.Point(197, 365);
            this.btnVizualizeazaMeciuri.Name = "btnVizualizeazaMeciuri";
            this.btnVizualizeazaMeciuri.Size = new System.Drawing.Size(143, 55);
            this.btnVizualizeazaMeciuri.TabIndex = 4;
            this.btnVizualizeazaMeciuri.Text = "Vizualizeaza meciuri";
            this.btnVizualizeazaMeciuri.UseVisualStyleBackColor = false;
            this.btnVizualizeazaMeciuri.Click += new System.EventHandler(this.btnVizualizeazaMeciuri_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(481, 107);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 46);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(481, 181);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(113, 46);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Location = new System.Drawing.Point(944, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 263);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(984, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apasa mai jos pentru a vizualiza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(959, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ce meciuri au avut cele mai multe pariuri";
            // 
            // buttonGolesteTreeView
            // 
            this.buttonGolesteTreeView.Location = new System.Drawing.Point(399, 305);
            this.buttonGolesteTreeView.Name = "buttonGolesteTreeView";
            this.buttonGolesteTreeView.Size = new System.Drawing.Size(60, 30);
            this.buttonGolesteTreeView.TabIndex = 10;
            this.buttonGolesteTreeView.Text = "Clear";
            this.buttonGolesteTreeView.UseVisualStyleBackColor = true;
            this.buttonGolesteTreeView.Click += new System.EventHandler(this.buttonGolesteTreeView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROIECT_PAW.Properties.Resources.pariuri_sportive;
            this.ClientSize = new System.Drawing.Size(1327, 569);
            this.Controls.Add(this.buttonGolesteTreeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnVizualizeazaMeciuri);
            this.Controls.Add(this.treeViewMeciuri);
            this.Controls.Add(this.btnPariaza);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporttxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaretxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anulareToolStripMenuItem;
        private System.Windows.Forms.Button btnPariaza;
        private System.Windows.Forms.TreeView treeViewMeciuri;
        private System.Windows.Forms.Button btnVizualizeazaMeciuri;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGolesteTreeView;
    }
}

