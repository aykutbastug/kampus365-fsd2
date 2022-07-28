namespace WinFormsApp1
{
    partial class frmHarcamaEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSube = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateHarcamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şube :";
            // 
            // cmbSube
            // 
            this.cmbSube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSube.FormattingEnabled = true;
            this.cmbSube.Location = new System.Drawing.Point(207, 41);
            this.cmbSube.Name = "cmbSube";
            this.cmbSube.Size = new System.Drawing.Size(357, 33);
            this.cmbSube.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(207, 80);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(357, 33);
            this.cmbPersonel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Harcama Tarihi :";
            // 
            // dateHarcamaTarihi
            // 
            this.dateHarcamaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHarcamaTarihi.Location = new System.Drawing.Point(208, 116);
            this.dateHarcamaTarihi.Name = "dateHarcamaTarihi";
            this.dateHarcamaTarihi.Size = new System.Drawing.Size(210, 31);
            this.dateHarcamaTarihi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiş No :";
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(207, 153);
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(211, 31);
            this.txtFisNo.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(995, 41);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(164, 89);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAciklama,
            this.colTutar});
            this.dataGridView1.Location = new System.Drawing.Point(3, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 658);
            this.dataGridView1.TabIndex = 5;
            // 
            // colAciklama
            // 
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.MinimumWidth = 8;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Width = 450;
            // 
            // colTutar
            // 
            this.colTutar.HeaderText = "Tutar";
            this.colTutar.MinimumWidth = 8;
            this.colTutar.Name = "colTutar";
            this.colTutar.Width = 150;
            // 
            // frmHarcamaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 918);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtFisNo);
            this.Controls.Add(this.dateHarcamaTarihi);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSube);
            this.Controls.Add(this.label1);
            this.Name = "frmHarcamaEkle";
            this.Text = "Harcama Ekle";
            this.Load += new System.EventHandler(this.frmHarcamaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbSube;
        private Label label2;
        private ComboBox cmbPersonel;
        private Label label3;
        private DateTimePicker dateHarcamaTarihi;
        private Label label4;
        private TextBox txtFisNo;
        private Button btnKaydet;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colAciklama;
        private DataGridViewTextBoxColumn colTutar;
    }
}