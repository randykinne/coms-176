namespace furniture_experts_app
{
    partial class formFurniture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFurniture));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblSalePriceOutput = new System.Windows.Forms.Label();
            this.lblSalesTaxOutput = new System.Windows.Forms.Label();
            this.lblDeliveryOutput = new System.Windows.Forms.Label();
            this.lblTotalDueOutput = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(208, 238);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(208, 274);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(143, 20);
            this.txtDiscount.TabIndex = 2;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.ForeColor = System.Drawing.Color.White;
            this.lblSalePrice.Location = new System.Drawing.Point(454, 229);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(55, 13);
            this.lblSalePrice.TabIndex = 3;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.ForeColor = System.Drawing.Color.White;
            this.lblSalesTax.Location = new System.Drawing.Point(454, 258);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(54, 13);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.Text = "Sales Tax";
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.ForeColor = System.Drawing.Color.White;
            this.lblTotalDue.Location = new System.Drawing.Point(454, 316);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(54, 13);
            this.lblTotalDue.TabIndex = 5;
            this.lblTotalDue.Text = "Total Due";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(91, 407);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(83, 39);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 407);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 39);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.ForeColor = System.Drawing.Color.White;
            this.lblDelivery.Location = new System.Drawing.Point(454, 287);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(45, 13);
            this.lblDelivery.TabIndex = 8;
            this.lblDelivery.Text = "Delivery";
            // 
            // lblSalePriceOutput
            // 
            this.lblSalePriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalePriceOutput.ForeColor = System.Drawing.Color.White;
            this.lblSalePriceOutput.Location = new System.Drawing.Point(530, 228);
            this.lblSalePriceOutput.Name = "lblSalePriceOutput";
            this.lblSalePriceOutput.Size = new System.Drawing.Size(85, 20);
            this.lblSalePriceOutput.TabIndex = 9;
            this.lblSalePriceOutput.Text = "$00.00";
            this.lblSalePriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTaxOutput
            // 
            this.lblSalesTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTaxOutput.ForeColor = System.Drawing.Color.White;
            this.lblSalesTaxOutput.Location = new System.Drawing.Point(530, 257);
            this.lblSalesTaxOutput.Name = "lblSalesTaxOutput";
            this.lblSalesTaxOutput.Size = new System.Drawing.Size(85, 20);
            this.lblSalesTaxOutput.TabIndex = 10;
            this.lblSalesTaxOutput.Text = "$00.00";
            this.lblSalesTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeliveryOutput
            // 
            this.lblDeliveryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeliveryOutput.ForeColor = System.Drawing.Color.White;
            this.lblDeliveryOutput.Location = new System.Drawing.Point(530, 286);
            this.lblDeliveryOutput.Name = "lblDeliveryOutput";
            this.lblDeliveryOutput.Size = new System.Drawing.Size(85, 20);
            this.lblDeliveryOutput.TabIndex = 11;
            this.lblDeliveryOutput.Text = "$00.00";
            this.lblDeliveryOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDueOutput
            // 
            this.lblTotalDueOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDueOutput.ForeColor = System.Drawing.Color.White;
            this.lblTotalDueOutput.Location = new System.Drawing.Point(530, 315);
            this.lblTotalDueOutput.Name = "lblTotalDueOutput";
            this.lblTotalDueOutput.Size = new System.Drawing.Size(85, 20);
            this.lblTotalDueOutput.TabIndex = 12;
            this.lblTotalDueOutput.Text = "$00.00";
            this.lblTotalDueOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.ForeColor = System.Drawing.Color.White;
            this.lblProductPrice.Location = new System.Drawing.Point(88, 241);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(77, 13);
            this.lblProductPrice.TabIndex = 13;
            this.lblProductPrice.Text = "Product Price: ";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.ForeColor = System.Drawing.Color.White;
            this.lblDiscountPercent.Location = new System.Drawing.Point(88, 277);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(92, 13);
            this.lblDiscountPercent.TabIndex = 14;
            this.lblDiscountPercent.Text = "Discount Percent:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(205, 210);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 16;
            this.lblError.Text = " ";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formFurniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(748, 498);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblTotalDueOutput);
            this.Controls.Add(this.lblDeliveryOutput);
            this.Controls.Add(this.lblSalesTaxOutput);
            this.Controls.Add(this.lblSalePriceOutput);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.lblSalesTax);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formFurniture";
            this.Text = "Furniture Experts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblSalePriceOutput;
        private System.Windows.Forms.Label lblSalesTaxOutput;
        private System.Windows.Forms.Label lblDeliveryOutput;
        private System.Windows.Forms.Label lblTotalDueOutput;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblError;
    }
}

