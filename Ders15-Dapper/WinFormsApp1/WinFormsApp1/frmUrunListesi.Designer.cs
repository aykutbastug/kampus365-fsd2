namespace WinFormsApp1
{
    partial class frmUrunListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniÜrünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliÜrünüGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliÜrünüSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1479, 1071);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜrünEkleToolStripMenuItem,
            this.seçiliÜrünüGüncelleToolStripMenuItem,
            this.seçiliÜrünüSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 133);
            // 
            // yeniÜrünEkleToolStripMenuItem
            // 
            this.yeniÜrünEkleToolStripMenuItem.Name = "yeniÜrünEkleToolStripMenuItem";
            this.yeniÜrünEkleToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.yeniÜrünEkleToolStripMenuItem.Text = "Yeni Ürün Ekle";
            this.yeniÜrünEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniÜrünEkleToolStripMenuItem_Click);
            // 
            // seçiliÜrünüGüncelleToolStripMenuItem
            // 
            this.seçiliÜrünüGüncelleToolStripMenuItem.Name = "seçiliÜrünüGüncelleToolStripMenuItem";
            this.seçiliÜrünüGüncelleToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.seçiliÜrünüGüncelleToolStripMenuItem.Text = "Seçili Ürünü Güncelle";
            this.seçiliÜrünüGüncelleToolStripMenuItem.Click += new System.EventHandler(this.seçiliÜrünüGüncelleToolStripMenuItem_Click);
            // 
            // seçiliÜrünüSilToolStripMenuItem
            // 
            this.seçiliÜrünüSilToolStripMenuItem.Name = "seçiliÜrünüSilToolStripMenuItem";
            this.seçiliÜrünüSilToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.seçiliÜrünüSilToolStripMenuItem.Text = "Seçili Ürünü Sil";
            this.seçiliÜrünüSilToolStripMenuItem.Click += new System.EventHandler(this.seçiliÜrünüSilToolStripMenuItem_Click);
            // 
            // frmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 1071);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrunListesi";
            this.Text = "Ürün Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem yeniÜrünEkleToolStripMenuItem;
        private ToolStripMenuItem seçiliÜrünüGüncelleToolStripMenuItem;
        private ToolStripMenuItem seçiliÜrünüSilToolStripMenuItem;
    }
}