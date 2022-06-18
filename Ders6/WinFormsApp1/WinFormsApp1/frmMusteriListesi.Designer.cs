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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriListesi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnYeniMusteriEkle = new System.Windows.Forms.ToolStripButton();
            this.btnDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listMusteriler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMusteriKodu = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblIl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmailAdresi = new System.Windows.Forms.Label();
            this.lblIsTelefonu = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCepTelefonu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniMusteriEkle,
            this.btnDuzenle,
            this.btnSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1448, 73);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnYeniMusteriEkle
            // 
            this.btnYeniMusteriEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeniMusteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMusteriEkle.Image")));
            this.btnYeniMusteriEkle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnYeniMusteriEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniMusteriEkle.Name = "btnYeniMusteriEkle";
            this.btnYeniMusteriEkle.Size = new System.Drawing.Size(68, 68);
            this.btnYeniMusteriEkle.Text = "Yeni Müşteri Oluştur";
            this.btnYeniMusteriEkle.Click += new System.EventHandler(this.btnYeniMusteriEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(52, 68);
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.ToolTipText = "Seçili Müşteriyi Güncelle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(68, 68);
            this.btnSil.Text = "toolStripButton3";
            this.btnSil.ToolTipText = "Seçili Müşteriyi Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // listMusteriler
            // 
            this.listMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listMusteriler.FormattingEnabled = true;
            this.listMusteriler.ItemHeight = 25;
            this.listMusteriler.Location = new System.Drawing.Point(12, 76);
            this.listMusteriler.Name = "listMusteriler";
            this.listMusteriler.Size = new System.Drawing.Size(651, 779);
            this.listMusteriler.TabIndex = 1;
            this.listMusteriler.SelectedIndexChanged += new System.EventHandler(this.listMusteriler_SelectedIndexChanged);
            this.listMusteriler.DoubleClick += new System.EventHandler(this.listMusteriler_DoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAdi
            // 
            this.lblAdi.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAdi.Location = new System.Drawing.Point(196, 86);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(427, 37);
            this.lblAdi.TabIndex = 2;
            this.lblAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSoyadi.Location = new System.Drawing.Point(196, 127);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(427, 37);
            this.lblSoyadi.TabIndex = 2;
            this.lblSoyadi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(17, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doğum Tarihi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDogumTarihi.Location = new System.Drawing.Point(196, 167);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(427, 37);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(17, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cinsiyet :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCinsiyet.Location = new System.Drawing.Point(196, 208);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(427, 37);
            this.lblCinsiyet.TabIndex = 2;
            this.lblCinsiyet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(679, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 783);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblCinsiyet);
            this.tabPage1.Controls.Add(this.lblDogumTarihi);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lblMusteriKodu);
            this.tabPage1.Controls.Add(this.lblAdi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblSoyadi);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 745);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(17, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 37);
            this.label16.TabIndex = 2;
            this.label16.Text = "Müşteri Kodu :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMusteriKodu
            // 
            this.lblMusteriKodu.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMusteriKodu.Location = new System.Drawing.Point(196, 44);
            this.lblMusteriKodu.Name = "lblMusteriKodu";
            this.lblMusteriKodu.Size = new System.Drawing.Size(427, 37);
            this.lblMusteriKodu.TabIndex = 2;
            this.lblMusteriKodu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lblAdres);
            this.tabPage2.Controls.Add(this.lblIl);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lblEmailAdresi);
            this.tabPage2.Controls.Add(this.lblIsTelefonu);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.lblCepTelefonu);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 745);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İletişim Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(17, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 37);
            this.label12.TabIndex = 2;
            this.label12.Text = "Cep Telefonu :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAdres
            // 
            this.lblAdres.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAdres.Location = new System.Drawing.Point(196, 177);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(535, 209);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIl
            // 
            this.lblIl.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIl.Location = new System.Drawing.Point(196, 136);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(535, 37);
            this.lblIl.TabIndex = 2;
            this.lblIl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(17, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email Adresi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(17, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "İş Telefonu :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailAdresi
            // 
            this.lblEmailAdresi.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEmailAdresi.Location = new System.Drawing.Point(196, 95);
            this.lblEmailAdresi.Name = "lblEmailAdresi";
            this.lblEmailAdresi.Size = new System.Drawing.Size(535, 37);
            this.lblEmailAdresi.TabIndex = 2;
            this.lblEmailAdresi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIsTelefonu
            // 
            this.lblIsTelefonu.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIsTelefonu.Location = new System.Drawing.Point(196, 55);
            this.lblIsTelefonu.Name = "lblIsTelefonu";
            this.lblIsTelefonu.Size = new System.Drawing.Size(535, 37);
            this.lblIsTelefonu.TabIndex = 2;
            this.lblIsTelefonu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(17, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 37);
            this.label13.TabIndex = 2;
            this.label13.Text = "Adres :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCepTelefonu
            // 
            this.lblCepTelefonu.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCepTelefonu.Location = new System.Drawing.Point(196, 14);
            this.lblCepTelefonu.Name = "lblCepTelefonu";
            this.lblCepTelefonu.Size = new System.Drawing.Size(535, 37);
            this.lblCepTelefonu.TabIndex = 2;
            this.lblCepTelefonu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(17, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 37);
            this.label9.TabIndex = 2;
            this.label9.Text = "İl :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 871);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listMusteriler);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMusteriListesi";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.frmMusteriListesi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnYeniMusteriEkle;
        private ToolStripButton btnDuzenle;
        private ToolStripButton btnSil;
        private ToolTip toolTip1;
        private ListBox listMusteriler;
        private Label label1;
        private Label lblAdi;
        private Label label3;
        private Label lblSoyadi;
        private Label label5;
        private Label lblDogumTarihi;
        private Label label7;
        private Label lblCinsiyet;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label12;
        private Label lblIl;
        private Label label4;
        private Label label6;
        private Label lblEmailAdresi;
        private Label lblIsTelefonu;
        private Label lblCepTelefonu;
        private Label label9;
        private Label lblAdres;
        private Label label13;
        private Label label16;
        private Label lblMusteriKodu;
    }
}