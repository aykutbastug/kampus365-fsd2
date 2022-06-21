namespace WinFormsApp1
{
    partial class frmYeniKisiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniKisiEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGrup = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGrupEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrup = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGrupKaydet = new System.Windows.Forms.Button();
            this.btnGrupIptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(135, 35);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(420, 31);
            this.txtTelefon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı Soyadı :";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(135, 72);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(420, 31);
            this.txtAdiSoyadi.TabIndex = 1;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(135, 109);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(420, 33);
            this.cmbCinsiyet.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cinsiyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Grup :";
            // 
            // cmbGrup
            // 
            this.cmbGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrup.FormattingEnabled = true;
            this.cmbGrup.Location = new System.Drawing.Point(135, 148);
            this.cmbGrup.Name = "cmbGrup";
            this.cmbGrup.Size = new System.Drawing.Size(377, 33);
            this.cmbGrup.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(443, 222);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 56);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(325, 222);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(112, 56);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGrupEkle
            // 
            this.btnGrupEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrupEkle.BackgroundImage")));
            this.btnGrupEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrupEkle.Location = new System.Drawing.Point(518, 147);
            this.btnGrupEkle.Name = "btnGrupEkle";
            this.btnGrupEkle.Size = new System.Drawing.Size(37, 35);
            this.btnGrupEkle.TabIndex = 6;
            this.btnGrupEkle.UseVisualStyleBackColor = true;
            this.btnGrupEkle.Click += new System.EventHandler(this.btnGrupEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Grup :";
            // 
            // txtGrup
            // 
            this.txtGrup.Location = new System.Drawing.Point(107, 53);
            this.txtGrup.Name = "txtGrup";
            this.txtGrup.Size = new System.Drawing.Size(420, 31);
            this.txtGrup.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnGrupKaydet);
            this.panel1.Controls.Add(this.btnGrupIptal);
            this.panel1.Controls.Add(this.txtGrup);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 175);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(541, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Grup Ekle";
            // 
            // btnGrupKaydet
            // 
            this.btnGrupKaydet.Location = new System.Drawing.Point(415, 107);
            this.btnGrupKaydet.Name = "btnGrupKaydet";
            this.btnGrupKaydet.Size = new System.Drawing.Size(112, 39);
            this.btnGrupKaydet.TabIndex = 4;
            this.btnGrupKaydet.Text = "Ekle";
            this.btnGrupKaydet.UseVisualStyleBackColor = true;
            this.btnGrupKaydet.Click += new System.EventHandler(this.btnGrupKaydet_Click);
            // 
            // btnGrupIptal
            // 
            this.btnGrupIptal.Location = new System.Drawing.Point(297, 107);
            this.btnGrupIptal.Name = "btnGrupIptal";
            this.btnGrupIptal.Size = new System.Drawing.Size(112, 39);
            this.btnGrupIptal.TabIndex = 5;
            this.btnGrupIptal.Text = "İptal";
            this.btnGrupIptal.UseVisualStyleBackColor = true;
            this.btnGrupIptal.Click += new System.EventHandler(this.btnGrupIptal_Click);
            // 
            // frmYeniKisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGrupEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbGrup);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmYeniKisiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kişi Ekle";
            this.Load += new System.EventHandler(this.frmYeniKisiEkle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmYeniKisiEkle_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTelefon;
        private Label label2;
        private TextBox txtAdiSoyadi;
        private ComboBox cmbCinsiyet;
        private Label label3;
        private Label label4;
        private ComboBox cmbGrup;
        private Button btnKaydet;
        private Button btnIptal;
        private Button btnGrupEkle;
        private Label label5;
        private TextBox txtGrup;
        private Panel panel1;
        private Label label6;
        private Button btnGrupKaydet;
        private Button btnGrupIptal;
    }
}