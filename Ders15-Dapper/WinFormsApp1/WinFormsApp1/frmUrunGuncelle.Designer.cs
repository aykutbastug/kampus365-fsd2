namespace WinFormsApp1
{
    partial class frmUrunGuncelle
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.nupReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.nupUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.nupUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.nupUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(467, 486);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(159, 71);
            this.btnIptal.TabIndex = 25;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(632, 486);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(159, 71);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(238, 368);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(22, 21);
            this.chkDiscontinued.TabIndex = 23;
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // nupReorderLevel
            // 
            this.nupReorderLevel.Location = new System.Drawing.Point(238, 329);
            this.nupReorderLevel.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupReorderLevel.Name = "nupReorderLevel";
            this.nupReorderLevel.Size = new System.Drawing.Size(282, 31);
            this.nupReorderLevel.TabIndex = 22;
            // 
            // nupUnitsOnOrder
            // 
            this.nupUnitsOnOrder.Location = new System.Drawing.Point(238, 292);
            this.nupUnitsOnOrder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupUnitsOnOrder.Name = "nupUnitsOnOrder";
            this.nupUnitsOnOrder.Size = new System.Drawing.Size(282, 31);
            this.nupUnitsOnOrder.TabIndex = 21;
            // 
            // nupUnitsInStock
            // 
            this.nupUnitsInStock.Location = new System.Drawing.Point(238, 255);
            this.nupUnitsInStock.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupUnitsInStock.Name = "nupUnitsInStock";
            this.nupUnitsInStock.Size = new System.Drawing.Size(282, 31);
            this.nupUnitsInStock.TabIndex = 20;
            // 
            // nupUnitPrice
            // 
            this.nupUnitPrice.DecimalPlaces = 2;
            this.nupUnitPrice.Location = new System.Drawing.Point(238, 218);
            this.nupUnitPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nupUnitPrice.Name = "nupUnitPrice";
            this.nupUnitPrice.Size = new System.Drawing.Size(282, 31);
            this.nupUnitPrice.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(25, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "Discontinued :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(238, 142);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(553, 33);
            this.cmbCategory.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(25, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "ReorderLevel :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Category :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(25, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "UnitsOnOrder :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(238, 103);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(553, 33);
            this.cmbSupplier.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(25, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "UnitsInStock :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Supplier :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(25, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "UnitPrice :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(238, 181);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(553, 31);
            this.txtQuantityPerUnit.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "QuantityPerUnit :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(238, 66);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(553, 31);
            this.txtProductName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(25, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 31);
            this.label10.TabIndex = 13;
            this.label10.Text = "Product Id :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(238, 29);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(553, 31);
            this.txtProductId.TabIndex = 15;
            // 
            // frmUrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 596);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkDiscontinued);
            this.Controls.Add(this.nupReorderLevel);
            this.Controls.Add(this.nupUnitsOnOrder);
            this.Controls.Add(this.nupUnitsInStock);
            this.Controls.Add(this.nupUnitPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUrunGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Güncelle";
            this.Load += new System.EventHandler(this.frmUrunGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIptal;
        private Button btnKaydet;
        public CheckBox chkDiscontinued;
        public NumericUpDown nupReorderLevel;
        public NumericUpDown nupUnitsOnOrder;
        public NumericUpDown nupUnitsInStock;
        public NumericUpDown nupUnitPrice;
        private Label label9;
        public ComboBox cmbCategory;
        private Label label8;
        private Label label3;
        private Label label7;
        public ComboBox cmbSupplier;
        private Label label6;
        private Label label2;
        private Label label5;
        public TextBox txtQuantityPerUnit;
        private Label label4;
        public TextBox txtProductName;
        private Label label1;
        private Label label10;
        public TextBox txtProductId;
    }
}