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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubeler = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnHarcamalar = new System.Windows.Forms.Button();
            this.btnVerileriYenile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamHarcama = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblToplamSubeSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblToplamPersonelSayisi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubeler
            // 
            this.btnSubeler.Location = new System.Drawing.Point(34, 25);
            this.btnSubeler.Name = "btnSubeler";
            this.btnSubeler.Size = new System.Drawing.Size(279, 78);
            this.btnSubeler.TabIndex = 0;
            this.btnSubeler.Text = "Şubeler";
            this.btnSubeler.UseVisualStyleBackColor = true;
            this.btnSubeler.Click += new System.EventHandler(this.btnSubeler_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Location = new System.Drawing.Point(319, 25);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(279, 78);
            this.btnPersoneller.TabIndex = 0;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnHarcamalar
            // 
            this.btnHarcamalar.Location = new System.Drawing.Point(604, 25);
            this.btnHarcamalar.Name = "btnHarcamalar";
            this.btnHarcamalar.Size = new System.Drawing.Size(279, 78);
            this.btnHarcamalar.TabIndex = 0;
            this.btnHarcamalar.Text = "Harcamalar";
            this.btnHarcamalar.UseVisualStyleBackColor = true;
            this.btnHarcamalar.Click += new System.EventHandler(this.btnHarcamalar_Click);
            // 
            // btnVerileriYenile
            // 
            this.btnVerileriYenile.Location = new System.Drawing.Point(949, 25);
            this.btnVerileriYenile.Name = "btnVerileriYenile";
            this.btnVerileriYenile.Size = new System.Drawing.Size(279, 78);
            this.btnVerileriYenile.TabIndex = 0;
            this.btnVerileriYenile.Text = "Verileri Yenile";
            this.btnVerileriYenile.UseVisualStyleBackColor = true;
            this.btnVerileriYenile.Click += new System.EventHandler(this.btnVerileriYenile_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Harcama Tutarı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToplamHarcama
            // 
            this.lblToplamHarcama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplamHarcama.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamHarcama.Location = new System.Drawing.Point(0, 61);
            this.lblToplamHarcama.Name = "lblToplamHarcama";
            this.lblToplamHarcama.Size = new System.Drawing.Size(394, 106);
            this.lblToplamHarcama.TabIndex = 1;
            this.lblToplamHarcama.Text = "0,00";
            this.lblToplamHarcama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lblToplamHarcama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 167);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.lblToplamSubeSayisi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(434, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 167);
            this.panel2.TabIndex = 2;
            // 
            // lblToplamSubeSayisi
            // 
            this.lblToplamSubeSayisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplamSubeSayisi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamSubeSayisi.Location = new System.Drawing.Point(0, 61);
            this.lblToplamSubeSayisi.Name = "lblToplamSubeSayisi";
            this.lblToplamSubeSayisi.Size = new System.Drawing.Size(394, 106);
            this.lblToplamSubeSayisi.TabIndex = 1;
            this.lblToplamSubeSayisi.Text = "0 Adet";
            this.lblToplamSubeSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 61);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Şube Sayısı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.lblToplamPersonelSayisi);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(834, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 167);
            this.panel3.TabIndex = 2;
            // 
            // lblToplamPersonelSayisi
            // 
            this.lblToplamPersonelSayisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplamPersonelSayisi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamPersonelSayisi.Location = new System.Drawing.Point(0, 61);
            this.lblToplamPersonelSayisi.Name = "lblToplamPersonelSayisi";
            this.lblToplamPersonelSayisi.Size = new System.Drawing.Size(394, 106);
            this.lblToplamPersonelSayisi.TabIndex = 1;
            this.lblToplamPersonelSayisi.Text = "0 Kişi";
            this.lblToplamPersonelSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 61);
            this.label6.TabIndex = 1;
            this.label6.Text = "Toplam Personel Sayısı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(34, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 568);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SubeAdi";
            this.Column1.HeaderText = "Şube Adı";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 500;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HarcamaToplami";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Harcama Toplamı";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 971);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerileriYenile);
            this.Controls.Add(this.btnHarcamalar);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.btnSubeler);
            this.Name = "Form1";
            this.Text = "Harcama Modülü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSubeler;
        private Button btnPersoneller;
        private Button btnHarcamalar;
        private Button btnVerileriYenile;
        private Label label1;
        private Label lblToplamHarcama;
        private Panel panel1;
        private Panel panel2;
        private Label lblToplamSubeSayisi;
        private Label label4;
        private Panel panel3;
        private Label lblToplamPersonelSayisi;
        private Label label6;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}