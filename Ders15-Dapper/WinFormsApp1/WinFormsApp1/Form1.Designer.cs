namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamayıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBorçRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriLoglarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kritikStokRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.müşteriYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.siparişYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1457, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamayıKapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // uygulamayıKapatToolStripMenuItem
            // 
            this.uygulamayıKapatToolStripMenuItem.Name = "uygulamayıKapatToolStripMenuItem";
            this.uygulamayıKapatToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.uygulamayıKapatToolStripMenuItem.Text = "Uygulamayı Kapat";
            // 
            // müşteriYönetimiToolStripMenuItem
            // 
            this.müşteriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListesiToolStripMenuItem,
            this.müşteriBorçRaporuToolStripMenuItem,
            this.müşteriLoglarıToolStripMenuItem});
            this.müşteriYönetimiToolStripMenuItem.Name = "müşteriYönetimiToolStripMenuItem";
            this.müşteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.müşteriYönetimiToolStripMenuItem.Text = "Müşteri Yönetimi";
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem_Click);
            // 
            // müşteriBorçRaporuToolStripMenuItem
            // 
            this.müşteriBorçRaporuToolStripMenuItem.Name = "müşteriBorçRaporuToolStripMenuItem";
            this.müşteriBorçRaporuToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.müşteriBorçRaporuToolStripMenuItem.Text = "Müşteri Borç Raporu";
            // 
            // müşteriLoglarıToolStripMenuItem
            // 
            this.müşteriLoglarıToolStripMenuItem.Name = "müşteriLoglarıToolStripMenuItem";
            this.müşteriLoglarıToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.müşteriLoglarıToolStripMenuItem.Text = "Müşteri Logları";
            this.müşteriLoglarıToolStripMenuItem.Click += new System.EventHandler(this.müşteriLoglarıToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünListesiToolStripMenuItem,
            this.kritikStokRaporuToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            this.ürünListesiToolStripMenuItem.Click += new System.EventHandler(this.ürünListesiToolStripMenuItem_Click);
            // 
            // kritikStokRaporuToolStripMenuItem
            // 
            this.kritikStokRaporuToolStripMenuItem.Name = "kritikStokRaporuToolStripMenuItem";
            this.kritikStokRaporuToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kritikStokRaporuToolStripMenuItem.Text = "Kritik Stok Raporu";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişListesiToolStripMenuItem});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişListesiToolStripMenuItem
            // 
            this.siparişListesiToolStripMenuItem.Name = "siparişListesiToolStripMenuItem";
            this.siparişListesiToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.siparişListesiToolStripMenuItem.Text = "Sipariş Listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 978);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem uygulamayıKapatToolStripMenuItem;
        private ToolStripMenuItem müşteriYönetimiToolStripMenuItem;
        private ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private ToolStripMenuItem müşteriBorçRaporuToolStripMenuItem;
        private ToolStripMenuItem müşteriLoglarıToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem ürünListesiToolStripMenuItem;
        private ToolStripMenuItem kritikStokRaporuToolStripMenuItem;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişListesiToolStripMenuItem;
    }
}