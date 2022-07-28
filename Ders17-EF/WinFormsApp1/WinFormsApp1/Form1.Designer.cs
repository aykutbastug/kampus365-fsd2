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
            this.btnSubeler = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnHarcamalar = new System.Windows.Forms.Button();
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
            this.btnPersoneller.Location = new System.Drawing.Point(34, 109);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(279, 78);
            this.btnPersoneller.TabIndex = 0;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnHarcamalar
            // 
            this.btnHarcamalar.Location = new System.Drawing.Point(34, 193);
            this.btnHarcamalar.Name = "btnHarcamalar";
            this.btnHarcamalar.Size = new System.Drawing.Size(279, 78);
            this.btnHarcamalar.TabIndex = 0;
            this.btnHarcamalar.Text = "Harcamalar";
            this.btnHarcamalar.UseVisualStyleBackColor = true;
            this.btnHarcamalar.Click += new System.EventHandler(this.btnHarcamalar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 971);
            this.Controls.Add(this.btnHarcamalar);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.btnSubeler);
            this.Name = "Form1";
            this.Text = "Harcama Modülü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSubeler;
        private Button btnPersoneller;
        private Button btnHarcamalar;
    }
}