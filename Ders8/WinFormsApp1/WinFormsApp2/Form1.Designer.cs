namespace WinFormsApp2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnReadExcel = new System.Windows.Forms.Button();
            this.btnReadXml = new System.Windows.Forms.Button();
            this.btnReadJson = new System.Windows.Forms.Button();
            this.txtSmsMetni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWriteJson = new System.Windows.Forms.Button();
            this.btnWriteXml = new System.Windows.Forms.Button();
            this.btnWriteExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(953, 1118);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Telefon";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı Soyadı";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Meslek";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlem Sonucu";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.Width = 350;
            // 
            // btnReadExcel
            // 
            this.btnReadExcel.Location = new System.Drawing.Point(974, 12);
            this.btnReadExcel.Name = "btnReadExcel";
            this.btnReadExcel.Size = new System.Drawing.Size(234, 57);
            this.btnReadExcel.TabIndex = 1;
            this.btnReadExcel.Text = "Listeyi Excel\'den Oku";
            this.btnReadExcel.UseVisualStyleBackColor = true;
            this.btnReadExcel.Click += new System.EventHandler(this.btnReadExcel_Click);
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(1214, 12);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(234, 57);
            this.btnReadXml.TabIndex = 1;
            this.btnReadXml.Text = "Listeyi XML\'den Oku";
            this.btnReadXml.UseVisualStyleBackColor = true;
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // btnReadJson
            // 
            this.btnReadJson.Location = new System.Drawing.Point(1454, 12);
            this.btnReadJson.Name = "btnReadJson";
            this.btnReadJson.Size = new System.Drawing.Size(234, 57);
            this.btnReadJson.TabIndex = 1;
            this.btnReadJson.Text = "Listeyi Json\'dan Oku";
            this.btnReadJson.UseVisualStyleBackColor = true;
            this.btnReadJson.Click += new System.EventHandler(this.btnReadJson_Click);
            // 
            // txtSmsMetni
            // 
            this.txtSmsMetni.Location = new System.Drawing.Point(974, 186);
            this.txtSmsMetni.Multiline = true;
            this.txtSmsMetni.Name = "txtSmsMetni";
            this.txtSmsMetni.Size = new System.Drawing.Size(714, 286);
            this.txtSmsMetni.TabIndex = 2;
            this.txtSmsMetni.Text = "Sayın {AdiSoyadi};\r\nMesajımıza cevap vermeyin bu bir reklam mesajıdır.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(979, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMS Metni :";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(1477, 487);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(211, 75);
            this.btnGonder.TabIndex = 1;
            this.btnGonder.Text = "SMS GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWriteJson);
            this.groupBox1.Controls.Add(this.btnWriteXml);
            this.groupBox1.Controls.Add(this.btnWriteExcel);
            this.groupBox1.Location = new System.Drawing.Point(976, 1007);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Sonuçlarını Dışa Aktar";
            // 
            // btnWriteJson
            // 
            this.btnWriteJson.Location = new System.Drawing.Point(487, 43);
            this.btnWriteJson.Name = "btnWriteJson";
            this.btnWriteJson.Size = new System.Drawing.Size(234, 57);
            this.btnWriteJson.TabIndex = 2;
            this.btnWriteJson.Text = "Json Olarak Kaydet";
            this.btnWriteJson.UseVisualStyleBackColor = true;
            this.btnWriteJson.Click += new System.EventHandler(this.btnWriteJson_Click);
            // 
            // btnWriteXml
            // 
            this.btnWriteXml.Location = new System.Drawing.Point(247, 43);
            this.btnWriteXml.Name = "btnWriteXml";
            this.btnWriteXml.Size = new System.Drawing.Size(234, 57);
            this.btnWriteXml.TabIndex = 3;
            this.btnWriteXml.Text = "Xml Olarak Kaydet";
            this.btnWriteXml.UseVisualStyleBackColor = true;
            this.btnWriteXml.Click += new System.EventHandler(this.btnWriteXml_Click);
            // 
            // btnWriteExcel
            // 
            this.btnWriteExcel.Location = new System.Drawing.Point(7, 43);
            this.btnWriteExcel.Name = "btnWriteExcel";
            this.btnWriteExcel.Size = new System.Drawing.Size(234, 57);
            this.btnWriteExcel.TabIndex = 4;
            this.btnWriteExcel.Text = "Excel Olarak Kaydet";
            this.btnWriteExcel.UseVisualStyleBackColor = true;
            this.btnWriteExcel.Click += new System.EventHandler(this.btnWriteExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 1133);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSmsMetni);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnReadJson);
            this.Controls.Add(this.btnReadXml);
            this.Controls.Add(this.btnReadExcel);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Toplu SMS Gönderim Uygualaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnReadExcel;
        private Button btnReadXml;
        private Button btnReadJson;
        private TextBox txtSmsMetni;
        private Label label1;
        private Button btnGonder;
        private GroupBox groupBox1;
        private Button btnWriteJson;
        private Button btnWriteXml;
        private Button btnWriteExcel;
        private ColumnHeader columnHeader5;
    }
}