namespace WindowsFormsApp1
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
            this.btnLoadNumberData = new System.Windows.Forms.Button();
            this.btnLoadStringData = new System.Windows.Forms.Button();
            this.btnLoadClassData = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadNumberData
            // 
            this.btnLoadNumberData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadNumberData.Location = new System.Drawing.Point(12, 12);
            this.btnLoadNumberData.Name = "btnLoadNumberData";
            this.btnLoadNumberData.Size = new System.Drawing.Size(514, 46);
            this.btnLoadNumberData.TabIndex = 0;
            this.btnLoadNumberData.Text = "Load Number Data";
            this.btnLoadNumberData.UseVisualStyleBackColor = true;
            this.btnLoadNumberData.Click += new System.EventHandler(this.btnLoadNumberData_Click);
            // 
            // btnLoadStringData
            // 
            this.btnLoadStringData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadStringData.Location = new System.Drawing.Point(12, 64);
            this.btnLoadStringData.Name = "btnLoadStringData";
            this.btnLoadStringData.Size = new System.Drawing.Size(514, 46);
            this.btnLoadStringData.TabIndex = 0;
            this.btnLoadStringData.Text = "Load String Data";
            this.btnLoadStringData.UseVisualStyleBackColor = true;
            this.btnLoadStringData.Click += new System.EventHandler(this.btnLoadStringData_Click);
            // 
            // btnLoadClassData
            // 
            this.btnLoadClassData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadClassData.Location = new System.Drawing.Point(12, 116);
            this.btnLoadClassData.Name = "btnLoadClassData";
            this.btnLoadClassData.Size = new System.Drawing.Size(514, 46);
            this.btnLoadClassData.TabIndex = 0;
            this.btnLoadClassData.Text = "Load Class Data";
            this.btnLoadClassData.UseVisualStyleBackColor = true;
            this.btnLoadClassData.Click += new System.EventHandler(this.btnLoadClassData_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(544, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(501, 704);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(1051, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(501, 704);
            this.listBox2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metinsel İşlemler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(478, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "X İle Başlayan Kayıtlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(478, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "Karakter Sayısı X den Büyük Olanlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(478, 46);
            this.button3.TabIndex = 0;
            this.button3.Text = "Kayıtları Sırala (Asc)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(478, 46);
            this.button4.TabIndex = 0;
            this.button4.Text = "Kayıtları Sırala (Desc)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 230);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sayısal İşlemler";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(478, 46);
            this.button6.TabIndex = 0;
            this.button6.Text = "Çift Sayıların Toplamı";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 105);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(478, 46);
            this.button7.TabIndex = 0;
            this.button7.Text = "Toplam/Ortalama/Max/Min";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(16, 53);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(478, 46);
            this.button8.TabIndex = 0;
            this.button8.Text = "X den Büyük Olan Kayıtlar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button16);
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 739);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 545);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class İşlemler";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(478, 46);
            this.button5.TabIndex = 0;
            this.button5.Text = "Kayıtları Sırala (Desc)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(16, 164);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(478, 46);
            this.button9.TabIndex = 0;
            this.button9.Text = "Kayıtları Sırala (Asc)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(16, 112);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(478, 46);
            this.button10.TabIndex = 0;
            this.button10.Text = "Soyadının Karakter Sayısı X den Büyük Olanlar";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(16, 60);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(478, 46);
            this.button11.TabIndex = 0;
            this.button11.Text = "Adı X İle Başlayan Personeller";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(16, 268);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(478, 46);
            this.button12.TabIndex = 0;
            this.button12.Text = "En Yaşlı Personel";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(16, 320);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(478, 46);
            this.button13.TabIndex = 0;
            this.button13.Text = "En Düşük Maaş";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(16, 372);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(478, 46);
            this.button14.TabIndex = 0;
            this.button14.Text = "Personel Maaş Toplamı";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(16, 424);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(478, 46);
            this.button15.TabIndex = 0;
            this.button15.Text = "Personel Yaş Ortalaması";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(16, 476);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(478, 46);
            this.button16.TabIndex = 0;
            this.button16.Text = "Kaç Farklı Şirket Sayısı Var";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(550, 755);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 528);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1298);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLoadClassData);
            this.Controls.Add(this.btnLoadStringData);
            this.Controls.Add(this.btnLoadNumberData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadNumberData;
        private System.Windows.Forms.Button btnLoadStringData;
        private System.Windows.Forms.Button btnLoadClassData;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

