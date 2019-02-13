namespace Program2Demo
{
    partial class frmCalculator
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTipOutput = new System.Windows.Forms.Label();
            this.lblTaxOutput = new System.Windows.Forms.Label();
            this.lblGrandTotalOutput = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(106, 94);
            this.txtInput.Name = "txtInput";
            this.txtInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInput.Size = new System.Drawing.Size(112, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(275, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(275, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(275, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(34, 101);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(52, 13);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal: ";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(58, 156);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(28, 13);
            this.lblTip.TabIndex = 7;
            this.lblTip.Text = "Tip: ";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(58, 190);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 13);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "Tax: ";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(34, 226);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(66, 13);
            this.lblGrandTotal.TabIndex = 9;
            this.lblGrandTotal.Text = "Grand Total:";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipOutput
            // 
            this.lblTipOutput.Location = new System.Drawing.Point(131, 156);
            this.lblTipOutput.Name = "lblTipOutput";
            this.lblTipOutput.Size = new System.Drawing.Size(100, 23);
            this.lblTipOutput.TabIndex = 10;
            this.lblTipOutput.Text = "$0.00";
            this.lblTipOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTaxOutput
            // 
            this.lblTaxOutput.Location = new System.Drawing.Point(131, 189);
            this.lblTaxOutput.Name = "lblTaxOutput";
            this.lblTaxOutput.Size = new System.Drawing.Size(100, 13);
            this.lblTaxOutput.TabIndex = 11;
            this.lblTaxOutput.Text = "$0.00";
            this.lblTaxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGrandTotalOutput
            // 
            this.lblGrandTotalOutput.Location = new System.Drawing.Point(131, 226);
            this.lblGrandTotalOutput.Name = "lblGrandTotalOutput";
            this.lblGrandTotalOutput.Size = new System.Drawing.Size(100, 13);
            this.lblGrandTotalOutput.TabIndex = 12;
            this.lblGrandTotalOutput.Text = "$0.00";
            this.lblGrandTotalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(131, 78);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 13;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblError.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Randy\'s Restaurant Tip Calculator";
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(396, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblGrandTotalOutput);
            this.Controls.Add(this.lblTaxOutput);
            this.Controls.Add(this.lblTipOutput);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtInput);
            this.Name = "frmCalculator";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTipOutput;
        private System.Windows.Forms.Label lblTaxOutput;
        private System.Windows.Forms.Label lblGrandTotalOutput;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
    }
}

