namespace WinFormsApp1
{
    partial class frmMusteriSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriSil));
            this.lblMusteriBilgisi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEvet = new System.Windows.Forms.Button();
            this.btnHayir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriBilgisi
            // 
            this.lblMusteriBilgisi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMusteriBilgisi.ForeColor = System.Drawing.Color.Red;
            this.lblMusteriBilgisi.Location = new System.Drawing.Point(289, 79);
            this.lblMusteriBilgisi.Name = "lblMusteriBilgisi";
            this.lblMusteriBilgisi.Size = new System.Drawing.Size(499, 140);
            this.lblMusteriBilgisi.TabIndex = 0;
            this.lblMusteriBilgisi.Text = "{MusteriAdiSoyadi} isimli müşteriyi silme istiyor musunuz ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnEvet
            // 
            this.btnEvet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEvet.Image = ((System.Drawing.Image)(resources.GetObject("btnEvet.Image")));
            this.btnEvet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvet.Location = new System.Drawing.Point(647, 303);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnEvet.Size = new System.Drawing.Size(141, 64);
            this.btnEvet.TabIndex = 2;
            this.btnEvet.Text = "Evet";
            this.btnEvet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEvet.UseVisualStyleBackColor = true;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // btnHayir
            // 
            this.btnHayir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHayir.Image = ((System.Drawing.Image)(resources.GetObject("btnHayir.Image")));
            this.btnHayir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHayir.Location = new System.Drawing.Point(494, 303);
            this.btnHayir.Name = "btnHayir";
            this.btnHayir.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnHayir.Size = new System.Drawing.Size(147, 64);
            this.btnHayir.TabIndex = 2;
            this.btnHayir.Text = "Hayır";
            this.btnHayir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHayir.UseVisualStyleBackColor = true;
            this.btnHayir.Click += new System.EventHandler(this.btnHayir_Click);
            // 
            // frmMusteriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.btnHayir);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMusteriBilgisi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriSil";
            this.Text = "Müşteri Sil";
            this.Load += new System.EventHandler(this.frmMusteriSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnEvet;
        private Button btnHayir;
        public Label lblMusteriBilgisi;
    }
}