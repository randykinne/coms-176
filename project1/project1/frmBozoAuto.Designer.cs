namespace project1
{
    partial class frmBozoAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBozoAuto));
            this.txtBoxIncome = new System.Windows.Forms.TextBox();
            this.txtBoxRent = new System.Windows.Forms.TextBox();
            this.txtOtherPayments = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAllowablePayment = new System.Windows.Forms.Label();
            this.lblMaxCarValue = new System.Windows.Forms.Label();
            this.rdoGoodCredit = new System.Windows.Forms.RadioButton();
            this.rdoOKCredit = new System.Windows.Forms.RadioButton();
            this.rdoBadCredit = new System.Windows.Forms.RadioButton();
            this.lstYears = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxIncome
            // 
            this.txtBoxIncome.Location = new System.Drawing.Point(40, 42);
            this.txtBoxIncome.Name = "txtBoxIncome";
            this.txtBoxIncome.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIncome.TabIndex = 0;
            this.txtBoxIncome.Text = "Monthly Income";
            this.txtBoxIncome.TextChanged += new System.EventHandler(this.txtBoxIncome_TextChanged);
            // 
            // txtBoxRent
            // 
            this.txtBoxRent.Location = new System.Drawing.Point(155, 42);
            this.txtBoxRent.Name = "txtBoxRent";
            this.txtBoxRent.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRent.TabIndex = 1;
            this.txtBoxRent.Text = "Rent/Mortgage";
            this.txtBoxRent.TextChanged += new System.EventHandler(this.txtBoxRent_TextChanged);
            // 
            // txtOtherPayments
            // 
            this.txtOtherPayments.Location = new System.Drawing.Point(272, 42);
            this.txtOtherPayments.Name = "txtOtherPayments";
            this.txtOtherPayments.Size = new System.Drawing.Size(133, 20);
            this.txtOtherPayments.TabIndex = 2;
            this.txtOtherPayments.Text = "Other Monthly Payments";
            this.txtOtherPayments.TextChanged += new System.EventHandler(this.txtOtherPayments_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 160);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(365, 34);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAllowablePayment
            // 
            this.lblAllowablePayment.AutoSize = true;
            this.lblAllowablePayment.Location = new System.Drawing.Point(196, 236);
            this.lblAllowablePayment.Name = "lblAllowablePayment";
            this.lblAllowablePayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAllowablePayment.Size = new System.Drawing.Size(28, 13);
            this.lblAllowablePayment.TabIndex = 8;
            this.lblAllowablePayment.Text = "0.00";
            this.lblAllowablePayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaxCarValue
            // 
            this.lblMaxCarValue.AutoSize = true;
            this.lblMaxCarValue.Location = new System.Drawing.Point(377, 236);
            this.lblMaxCarValue.Name = "lblMaxCarValue";
            this.lblMaxCarValue.Size = new System.Drawing.Size(28, 13);
            this.lblMaxCarValue.TabIndex = 9;
            this.lblMaxCarValue.Text = "0.00";
            // 
            // rdoGoodCredit
            // 
            this.rdoGoodCredit.AutoSize = true;
            this.rdoGoodCredit.Location = new System.Drawing.Point(40, 72);
            this.rdoGoodCredit.Name = "rdoGoodCredit";
            this.rdoGoodCredit.Size = new System.Drawing.Size(81, 17);
            this.rdoGoodCredit.TabIndex = 3;
            this.rdoGoodCredit.TabStop = true;
            this.rdoGoodCredit.Text = "Good Credit";
            this.rdoGoodCredit.UseVisualStyleBackColor = true;
            this.rdoGoodCredit.CheckedChanged += new System.EventHandler(this.rdoGoodCredit_CheckedChanged);
            // 
            // rdoOKCredit
            // 
            this.rdoOKCredit.AutoSize = true;
            this.rdoOKCredit.Location = new System.Drawing.Point(168, 72);
            this.rdoOKCredit.Name = "rdoOKCredit";
            this.rdoOKCredit.Size = new System.Drawing.Size(70, 17);
            this.rdoOKCredit.TabIndex = 4;
            this.rdoOKCredit.TabStop = true;
            this.rdoOKCredit.Text = "OK Credit";
            this.rdoOKCredit.UseVisualStyleBackColor = true;
            this.rdoOKCredit.CheckedChanged += new System.EventHandler(this.rdoOKCredit_CheckedChanged);
            // 
            // rdoBadCredit
            // 
            this.rdoBadCredit.AutoSize = true;
            this.rdoBadCredit.Location = new System.Drawing.Point(292, 72);
            this.rdoBadCredit.Name = "rdoBadCredit";
            this.rdoBadCredit.Size = new System.Drawing.Size(74, 17);
            this.rdoBadCredit.TabIndex = 5;
            this.rdoBadCredit.TabStop = true;
            this.rdoBadCredit.Text = "Bad Credit";
            this.rdoBadCredit.UseVisualStyleBackColor = true;
            this.rdoBadCredit.CheckedChanged += new System.EventHandler(this.rdoBadCredit_CheckedChanged);
            // 
            // lstYears
            // 
            this.lstYears.FormattingEnabled = true;
            this.lstYears.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.lstYears.Location = new System.Drawing.Point(180, 95);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(41, 43);
            this.lstYears.TabIndex = 6;
            this.lstYears.SelectedIndexChanged += new System.EventHandler(this.lstYears_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Allowable Monthly Car Payment: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Maximum Car Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bozo Automotive";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Number of Years:";
            // 
            // frmBozoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 277);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstYears);
            this.Controls.Add(this.rdoBadCredit);
            this.Controls.Add(this.rdoOKCredit);
            this.Controls.Add(this.rdoGoodCredit);
            this.Controls.Add(this.lblMaxCarValue);
            this.Controls.Add(this.lblAllowablePayment);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOtherPayments);
            this.Controls.Add(this.txtBoxRent);
            this.Controls.Add(this.txtBoxIncome);
            this.Name = "frmBozoAuto";
            this.Text = "Bozo Auto Automatic Loan Qualifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIncome;
        private System.Windows.Forms.TextBox txtBoxRent;
        private System.Windows.Forms.TextBox txtOtherPayments;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAllowablePayment;
        private System.Windows.Forms.Label lblMaxCarValue;
        private System.Windows.Forms.RadioButton rdoGoodCredit;
        private System.Windows.Forms.RadioButton rdoOKCredit;
        private System.Windows.Forms.RadioButton rdoBadCredit;
        private System.Windows.Forms.ListBox lstYears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

