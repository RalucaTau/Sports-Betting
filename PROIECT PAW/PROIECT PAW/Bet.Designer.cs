namespace PROIECT_PAW
{
    partial class Bet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bet));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSoldUtilizator = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBoxMeciuri = new System.Windows.Forms.ComboBox();
            this.comboBoxSumaBani = new System.Windows.Forms.ComboBox();
            this.btnInregistrarePariu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtSold = new System.Windows.Forms.TextBox();
            this.btnIntroducereSold = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSold = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripBttnDelete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSold)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1015, 26);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 20);
            this.toolStripStatusLabel1.Text = "Sold:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblSoldUtilizator
            // 
            this.lblSoldUtilizator.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.lblSoldUtilizator.Name = "lblSoldUtilizator";
            this.lblSoldUtilizator.Size = new System.Drawing.Size(39, 20);
            this.lblSoldUtilizator.Text = "Sold";
            this.lblSoldUtilizator.Click += new System.EventHandler(this.lblSoldUtilizator_Click);
            // 
            // comboBoxMeciuri
            // 
            this.comboBoxMeciuri.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxMeciuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMeciuri.FormattingEnabled = true;
            this.comboBoxMeciuri.Location = new System.Drawing.Point(33, 112);
            this.comboBoxMeciuri.Name = "comboBoxMeciuri";
            this.comboBoxMeciuri.Size = new System.Drawing.Size(342, 28);
            this.comboBoxMeciuri.TabIndex = 1;
            this.comboBoxMeciuri.Text = "Selecteaza meciul";
            this.comboBoxMeciuri.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeciuri_SelectedIndexChanged);
            // 
            // comboBoxSumaBani
            // 
            this.comboBoxSumaBani.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSumaBani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSumaBani.FormattingEnabled = true;
            this.comboBoxSumaBani.Location = new System.Drawing.Point(33, 153);
            this.comboBoxSumaBani.Name = "comboBoxSumaBani";
            this.comboBoxSumaBani.Size = new System.Drawing.Size(342, 28);
            this.comboBoxSumaBani.TabIndex = 2;
            this.comboBoxSumaBani.Text = "Selecteaza suma cu care pariezi";
            this.comboBoxSumaBani.SelectedIndexChanged += new System.EventHandler(this.comboBoxSumaBani_SelectedIndexChanged);
            // 
            // btnInregistrarePariu
            // 
            this.btnInregistrarePariu.BackColor = System.Drawing.Color.Red;
            this.btnInregistrarePariu.ContextMenuStrip = this.contextMenuStrip1;
            this.btnInregistrarePariu.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrarePariu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInregistrarePariu.Location = new System.Drawing.Point(33, 202);
            this.btnInregistrarePariu.Name = "btnInregistrarePariu";
            this.btnInregistrarePariu.Size = new System.Drawing.Size(145, 57);
            this.btnInregistrarePariu.TabIndex = 3;
            this.btnInregistrarePariu.Text = "Pariaza!";
            this.btnInregistrarePariu.UseVisualStyleBackColor = false;
            this.btnInregistrarePariu.Click += new System.EventHandler(this.btnInregistrarePariu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1015, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonHome
            // 
            this.toolStripButtonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHome.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHome.Image")));
            this.toolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHome.Name = "toolStripButtonHome";
            this.toolStripButtonHome.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonHome.Text = "Home";
            this.toolStripButtonHome.Click += new System.EventHandler(this.toolStripButtonHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(793, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(761, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(746, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sold";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(798, 222);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(159, 22);
            this.txtNume.TabIndex = 10;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // txtSold
            // 
            this.txtSold.Location = new System.Drawing.Point(798, 285);
            this.txtSold.Name = "txtSold";
            this.txtSold.Size = new System.Drawing.Size(100, 22);
            this.txtSold.TabIndex = 12;
            this.txtSold.TextChanged += new System.EventHandler(this.txtSold_TextChanged);
            // 
            // btnIntroducereSold
            // 
            this.btnIntroducereSold.BackColor = System.Drawing.Color.Green;
            this.btnIntroducereSold.Font = new System.Drawing.Font("Helvetica Rounded", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroducereSold.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIntroducereSold.Location = new System.Drawing.Point(772, 343);
            this.btnIntroducereSold.Name = "btnIntroducereSold";
            this.btnIntroducereSold.Size = new System.Drawing.Size(164, 73);
            this.btnIntroducereSold.TabIndex = 13;
            this.btnIntroducereSold.Text = "Introdu soldul!";
            this.btnIntroducereSold.UseVisualStyleBackColor = false;
            this.btnIntroducereSold.Click += new System.EventHandler(this.btnIntroducereSold_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProviderSold
            // 
            this.errorProviderSold.ContainerControl = this;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(798, 173);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 14;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Info;
            this.treeView1.Location = new System.Drawing.Point(33, 308);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(354, 166);
            this.treeView1.TabIndex = 17;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBttnDelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1015, 27);
            this.toolStrip2.TabIndex = 19;
            this.toolStrip2.Text = "Stergere";
            // 
            // toolStripBttnDelete
            // 
            this.toolStripBttnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBttnDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBttnDelete.Image")));
            this.toolStripBttnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBttnDelete.Name = "toolStripBttnDelete";
            this.toolStripBttnDelete.Size = new System.Drawing.Size(29, 24);
            this.toolStripBttnDelete.Text = "Stergere id";
            this.toolStripBttnDelete.Click += new System.EventHandler(this.toolStripBttnDelete_Click);
            // 
            // Bet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROIECT_PAW.Properties.Resources.footbet;
            this.ClientSize = new System.Drawing.Size(1015, 534);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnIntroducereSold);
            this.Controls.Add(this.txtSold);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnInregistrarePariu);
            this.Controls.Add(this.comboBoxSumaBani);
            this.Controls.Add(this.comboBoxMeciuri);
            this.Controls.Add(this.statusStrip1);
            this.KeyPreview = true;
            this.Name = "Bet";
            this.Text = "Bet";
            this.Load += new System.EventHandler(this.Bet_Load_1);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSold)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSoldUtilizator;
        private System.Windows.Forms.ComboBox comboBoxMeciuri;
        private System.Windows.Forms.ComboBox comboBoxSumaBani;
        private System.Windows.Forms.Button btnInregistrarePariu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtSold;
        private System.Windows.Forms.Button btnIntroducereSold;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProviderSold;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripBttnDelete;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}