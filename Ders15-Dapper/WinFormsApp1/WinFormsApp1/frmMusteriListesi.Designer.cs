namespace WinFormsApp1
{
    partial class frmMusteriListesi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniMüşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gggggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.müşteriyiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriLoglarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsdfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsfdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsfdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip2;
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 74);
            this.panel1.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriEkleToolStripMenuItem,
            this.gggggToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(216, 68);
            // 
            // yeniMüşteriEkleToolStripMenuItem
            // 
            this.yeniMüşteriEkleToolStripMenuItem.Name = "yeniMüşteriEkleToolStripMenuItem";
            this.yeniMüşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.yeniMüşteriEkleToolStripMenuItem.Text = "Yeni Müşteri Ekle";
            // 
            // gggggToolStripMenuItem
            // 
            this.gggggToolStripMenuItem.Name = "gggggToolStripMenuItem";
            this.gggggToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.gggggToolStripMenuItem.Text = "ggggg";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(577, 20);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(92, 38);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(130, 24);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(441, 31);
            this.txtAra.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtAra, "Müşteri telefon numarası ve ismine göre arama yapabilirsiniz.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Ara :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1410, 955);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerID";
            this.Column1.HeaderText = "Müşteri No";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriyiGüncelleToolStripMenuItem,
            this.müşteriyiSilToolStripMenuItem,
            this.müşteriLoglarıToolStripMenuItem,
            this.sdfsdfToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 132);
            // 
            // müşteriyiGüncelleToolStripMenuItem
            // 
            this.müşteriyiGüncelleToolStripMenuItem.Name = "müşteriyiGüncelleToolStripMenuItem";
            this.müşteriyiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.müşteriyiGüncelleToolStripMenuItem.Text = "Müşteriyi Güncelle";
            this.müşteriyiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.müşteriyiGüncelleToolStripMenuItem_Click);
            // 
            // müşteriyiSilToolStripMenuItem
            // 
            this.müşteriyiSilToolStripMenuItem.Name = "müşteriyiSilToolStripMenuItem";
            this.müşteriyiSilToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.müşteriyiSilToolStripMenuItem.Text = "Müşteriyi Sil";
            this.müşteriyiSilToolStripMenuItem.Click += new System.EventHandler(this.müşteriyiSilToolStripMenuItem_Click);
            // 
            // müşteriLoglarıToolStripMenuItem
            // 
            this.müşteriLoglarıToolStripMenuItem.Name = "müşteriLoglarıToolStripMenuItem";
            this.müşteriLoglarıToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.müşteriLoglarıToolStripMenuItem.Text = "Müşteri Logları";
            // 
            // sdfsdfToolStripMenuItem
            // 
            this.sdfsdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfsdfToolStripMenuItem1,
            this.sdfsfdfToolStripMenuItem});
            this.sdfsdfToolStripMenuItem.Name = "sdfsdfToolStripMenuItem";
            this.sdfsdfToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.sdfsdfToolStripMenuItem.Text = "sdfsdf";
            // 
            // sdfsdfToolStripMenuItem1
            // 
            this.sdfsdfToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfToolStripMenuItem,
            this.sdfsfdToolStripMenuItem});
            this.sdfsdfToolStripMenuItem1.Name = "sdfsdfToolStripMenuItem1";
            this.sdfsdfToolStripMenuItem1.Size = new System.Drawing.Size(170, 34);
            this.sdfsdfToolStripMenuItem1.Text = "sdfsdf";
            // 
            // sdfToolStripMenuItem
            // 
            this.sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
            this.sdfToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.sdfToolStripMenuItem.Text = "sdf";
            // 
            // sdfsfdToolStripMenuItem
            // 
            this.sdfsfdToolStripMenuItem.Name = "sdfsfdToolStripMenuItem";
            this.sdfsfdToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.sdfsfdToolStripMenuItem.Text = "sdfsfd";
            // 
            // sdfsfdfToolStripMenuItem
            // 
            this.sdfsfdfToolStripMenuItem.Name = "sdfsfdfToolStripMenuItem";
            this.sdfsfdfToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.sdfsfdfToolStripMenuItem.Text = "sdfsfdf";
            // 
            // frmMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 1029);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMusteriListesi";
            this.Text = "Müşteri Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMusteriListesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox txtAra;
        private ToolTip toolTip1;
        private Label label1;
        private Button btnAra;
        private DataGridViewTextBoxColumn Column1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem müşteriyiGüncelleToolStripMenuItem;
        private ToolStripMenuItem müşteriyiSilToolStripMenuItem;
        private ToolStripMenuItem müşteriLoglarıToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem yeniMüşteriEkleToolStripMenuItem;
        private ToolStripMenuItem gggggToolStripMenuItem;
        private ToolStripMenuItem sdfsdfToolStripMenuItem;
        private ToolStripMenuItem sdfsdfToolStripMenuItem1;
        private ToolStripMenuItem sdfToolStripMenuItem;
        private ToolStripMenuItem sdfsfdToolStripMenuItem;
        private ToolStripMenuItem sdfsfdfToolStripMenuItem;
    }
}