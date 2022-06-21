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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvKisiler = new System.Windows.Forms.ListView();
            this.colImage = new System.Windows.Forms.ColumnHeader("(none)");
            this.colTelefon = new System.Windows.Forms.ColumnHeader();
            this.colAdiSoyadi = new System.Windows.Forms.ColumnHeader();
            this.colGrup = new System.Windows.Forms.ColumnHeader();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDoseme = new System.Windows.Forms.RadioButton();
            this.rbtnListe = new System.Windows.Forms.RadioButton();
            this.rbtnKucukSimge = new System.Windows.Forms.RadioButton();
            this.rbtnBuyukSimge = new System.Windows.Forms.RadioButton();
            this.rbtnDetayliGorunum = new System.Windows.Forms.RadioButton();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnFiltreyiKaldir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvKisiler
            // 
            this.lvKisiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvKisiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colImage,
            this.colTelefon,
            this.colAdiSoyadi,
            this.colGrup});
            this.lvKisiler.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvKisiler.LargeImageList = this.imageList2;
            this.lvKisiler.Location = new System.Drawing.Point(12, 164);
            this.lvKisiler.Name = "lvKisiler";
            this.lvKisiler.Size = new System.Drawing.Size(1360, 908);
            this.lvKisiler.SmallImageList = this.imageList1;
            this.lvKisiler.TabIndex = 0;
            this.lvKisiler.UseCompatibleStateImageBehavior = false;
            this.lvKisiler.View = System.Windows.Forms.View.Tile;
            // 
            // colImage
            // 
            this.colImage.Text = "";
            // 
            // colTelefon
            // 
            this.colTelefon.Text = "Telefon";
            this.colTelefon.Width = 150;
            // 
            // colAdiSoyadi
            // 
            this.colAdiSoyadi.Text = "Adı Soyadı";
            this.colAdiSoyadi.Width = 300;
            // 
            // colGrup
            // 
            this.colGrup.Text = "Grup";
            this.colGrup.Width = 150;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "bayan");
            this.imageList2.Images.SetKeyName(1, "bay");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bayan");
            this.imageList1.Images.SetKeyName(1, "bay");
            // 
            // txtBul
            // 
            this.txtBul.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBul.Location = new System.Drawing.Point(12, 12);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(410, 53);
            this.txtBul.TabIndex = 1;
            this.txtBul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBul_KeyDown);
            this.txtBul.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBul_KeyUp);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(427, 12);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(86, 53);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(1023, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 53);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Yeni Kişi Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1152, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 53);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbtnDoseme);
            this.groupBox1.Controls.Add(this.rbtnListe);
            this.groupBox1.Controls.Add(this.rbtnKucukSimge);
            this.groupBox1.Controls.Add(this.rbtnBuyukSimge);
            this.groupBox1.Controls.Add(this.rbtnDetayliGorunum);
            this.groupBox1.Location = new System.Drawing.Point(759, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Görünüm";
            // 
            // rbtnDoseme
            // 
            this.rbtnDoseme.AutoSize = true;
            this.rbtnDoseme.Checked = true;
            this.rbtnDoseme.Location = new System.Drawing.Point(487, 35);
            this.rbtnDoseme.Name = "rbtnDoseme";
            this.rbtnDoseme.Size = new System.Drawing.Size(103, 29);
            this.rbtnDoseme.TabIndex = 0;
            this.rbtnDoseme.TabStop = true;
            this.rbtnDoseme.Text = "Döşeme";
            this.rbtnDoseme.UseVisualStyleBackColor = true;
            this.rbtnDoseme.CheckedChanged += new System.EventHandler(this.rbtnDoseme_CheckedChanged);
            // 
            // rbtnListe
            // 
            this.rbtnListe.AutoSize = true;
            this.rbtnListe.Location = new System.Drawing.Point(409, 35);
            this.rbtnListe.Name = "rbtnListe";
            this.rbtnListe.Size = new System.Drawing.Size(72, 29);
            this.rbtnListe.TabIndex = 0;
            this.rbtnListe.Text = "Liste";
            this.rbtnListe.UseVisualStyleBackColor = true;
            this.rbtnListe.CheckedChanged += new System.EventHandler(this.rbtnDetayliGorunum_CheckedChanged);
            // 
            // rbtnKucukSimge
            // 
            this.rbtnKucukSimge.AutoSize = true;
            this.rbtnKucukSimge.Location = new System.Drawing.Point(264, 35);
            this.rbtnKucukSimge.Name = "rbtnKucukSimge";
            this.rbtnKucukSimge.Size = new System.Drawing.Size(139, 29);
            this.rbtnKucukSimge.TabIndex = 0;
            this.rbtnKucukSimge.Text = "Küçük Simge";
            this.rbtnKucukSimge.UseVisualStyleBackColor = true;
            this.rbtnKucukSimge.CheckedChanged += new System.EventHandler(this.rbtnDetayliGorunum_CheckedChanged);
            // 
            // rbtnBuyukSimge
            // 
            this.rbtnBuyukSimge.AutoSize = true;
            this.rbtnBuyukSimge.Location = new System.Drawing.Point(118, 35);
            this.rbtnBuyukSimge.Name = "rbtnBuyukSimge";
            this.rbtnBuyukSimge.Size = new System.Drawing.Size(140, 29);
            this.rbtnBuyukSimge.TabIndex = 0;
            this.rbtnBuyukSimge.Text = "Büyük Simge";
            this.rbtnBuyukSimge.UseVisualStyleBackColor = true;
            this.rbtnBuyukSimge.CheckedChanged += new System.EventHandler(this.rbtnDetayliGorunum_CheckedChanged);
            // 
            // rbtnDetayliGorunum
            // 
            this.rbtnDetayliGorunum.AutoSize = true;
            this.rbtnDetayliGorunum.Location = new System.Drawing.Point(12, 35);
            this.rbtnDetayliGorunum.Name = "rbtnDetayliGorunum";
            this.rbtnDetayliGorunum.Size = new System.Drawing.Size(91, 29);
            this.rbtnDetayliGorunum.TabIndex = 0;
            this.rbtnDetayliGorunum.Text = "Detaylı";
            this.rbtnDetayliGorunum.UseVisualStyleBackColor = true;
            this.rbtnDetayliGorunum.CheckedChanged += new System.EventHandler(this.rbtnDetayliGorunum_CheckedChanged);
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(1241, 12);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(129, 53);
            this.btnOku.TabIndex = 2;
            this.btnOku.Text = "Dosyayı Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnFiltreyiKaldir
            // 
            this.btnFiltreyiKaldir.Location = new System.Drawing.Point(516, 12);
            this.btnFiltreyiKaldir.Name = "btnFiltreyiKaldir";
            this.btnFiltreyiKaldir.Size = new System.Drawing.Size(146, 53);
            this.btnFiltreyiKaldir.TabIndex = 2;
            this.btnFiltreyiKaldir.Text = "Filteri Kaldır";
            this.btnFiltreyiKaldir.UseVisualStyleBackColor = true;
            this.btnFiltreyiKaldir.Click += new System.EventHandler(this.btnFiltreyiKaldir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 1084);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnFiltreyiKaldir);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.lvKisiler);
            this.Name = "Form1";
            this.Text = "Telefon Defterim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvKisiler;
        private ColumnHeader colImage;
        private ColumnHeader colTelefon;
        private ImageList imageList2;
        private ImageList imageList1;
        private ColumnHeader colAdiSoyadi;
        private ColumnHeader colGrup;
        private TextBox txtBul;
        private Button btnBul;
        private Button btnEkle;
        private Button btnKaydet;
        private GroupBox groupBox1;
        private RadioButton rbtnDetayliGorunum;
        private RadioButton rbtnListe;
        private RadioButton rbtnKucukSimge;
        private RadioButton rbtnBuyukSimge;
        private RadioButton rbtnDoseme;
        private Button btnOku;
        private Button btnFiltreyiKaldir;
    }
}