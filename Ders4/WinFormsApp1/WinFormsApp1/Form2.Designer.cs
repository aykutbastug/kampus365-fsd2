namespace WinFormsApp1
{
    partial class Form2
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
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(253, 41);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(252, 31);
            this.txtNot1.TabIndex = 0;
            this.txtNot1.TextChanged += new System.EventHandler(this.txtNot1_TextChanged);
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(253, 78);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(252, 31);
            this.txtNot2.TabIndex = 1;
            this.txtNot2.TextChanged += new System.EventHandler(this.txtNot1_TextChanged);
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(253, 115);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(252, 31);
            this.txtNot3.TabIndex = 2;
            this.txtNot3.TextChanged += new System.EventHandler(this.txtNot1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(166, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Not :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(166, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Not :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(166, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "3. Not :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(253, 180);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(252, 61);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Not Ortalamasını Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrtalama.ForeColor = System.Drawing.Color.Red;
            this.lblOrtalama.Location = new System.Drawing.Point(253, 283);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(252, 51);
            this.lblOrtalama.TabIndex = 3;
            this.lblOrtalama.Text = "0";
            this.lblOrtalama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNot3);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.txtNot1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNot1;
        private TextBox txtNot2;
        private TextBox txtNot3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnHesapla;
        private Label lblOrtalama;
    }
}