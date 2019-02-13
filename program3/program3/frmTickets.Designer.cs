namespace program3
{
    partial class frmTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTickets));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstAdult = new System.Windows.Forms.ListBox();
            this.lstChildren = new System.Windows.Forms.ListBox();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.rdoTwo = new System.Windows.Forms.RadioButton();
            this.ChkParking = new System.Windows.Forms.CheckBox();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescribeAdults = new System.Windows.Forms.Label();
            this.lblDescribeChildren = new System.Windows.Forms.Label();
            this.lblDescribeTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lstAdult
            // 
            this.lstAdult.FormattingEnabled = true;
            this.lstAdult.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.lstAdult.Location = new System.Drawing.Point(53, 361);
            this.lstAdult.Name = "lstAdult";
            this.lstAdult.Size = new System.Drawing.Size(120, 95);
            this.lstAdult.TabIndex = 1;
            this.lstAdult.SelectedIndexChanged += new System.EventHandler(this.lstAdult_SelectedIndexChanged);
            // 
            // lstChildren
            // 
            this.lstChildren.FormattingEnabled = true;
            this.lstChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.lstChildren.Location = new System.Drawing.Point(247, 361);
            this.lstChildren.Name = "lstChildren";
            this.lstChildren.Size = new System.Drawing.Size(120, 95);
            this.lstChildren.TabIndex = 2;
            this.lstChildren.SelectedIndexChanged += new System.EventHandler(this.lstChildren_SelectedIndexChanged);
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Location = new System.Drawing.Point(441, 360);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(76, 17);
            this.rdoSingle.TabIndex = 3;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Single Day";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // rdoTwo
            // 
            this.rdoTwo.AutoSize = true;
            this.rdoTwo.Location = new System.Drawing.Point(441, 383);
            this.rdoTwo.Name = "rdoTwo";
            this.rdoTwo.Size = new System.Drawing.Size(68, 17);
            this.rdoTwo.TabIndex = 4;
            this.rdoTwo.TabStop = true;
            this.rdoTwo.Text = "Two Day";
            this.rdoTwo.UseVisualStyleBackColor = true;
            this.rdoTwo.CheckedChanged += new System.EventHandler(this.rdoTwo_CheckedChanged);
            // 
            // ChkParking
            // 
            this.ChkParking.AutoSize = true;
            this.ChkParking.Location = new System.Drawing.Point(532, 361);
            this.ChkParking.Name = "ChkParking";
            this.ChkParking.Size = new System.Drawing.Size(88, 17);
            this.ChkParking.TabIndex = 5;
            this.ChkParking.Text = "Parking Pass";
            this.ChkParking.UseVisualStyleBackColor = true;
            // 
            // btnAdvance
            // 
            this.btnAdvance.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdvance.Location = new System.Drawing.Point(662, 336);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(141, 57);
            this.btnAdvance.TabIndex = 6;
            this.btnAdvance.Text = "Pay in Advance";
            this.btnAdvance.UseVisualStyleBackColor = false;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(662, 399);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 57);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(745, 237);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0.00";
            // 
            // lblDescribeAdults
            // 
            this.lblDescribeAdults.AutoSize = true;
            this.lblDescribeAdults.Location = new System.Drawing.Point(65, 345);
            this.lblDescribeAdults.Name = "lblDescribeAdults";
            this.lblDescribeAdults.Size = new System.Drawing.Size(91, 13);
            this.lblDescribeAdults.TabIndex = 9;
            this.lblDescribeAdults.Text = "Number of Adults:";
            // 
            // lblDescribeChildren
            // 
            this.lblDescribeChildren.AutoSize = true;
            this.lblDescribeChildren.Location = new System.Drawing.Point(255, 345);
            this.lblDescribeChildren.Name = "lblDescribeChildren";
            this.lblDescribeChildren.Size = new System.Drawing.Size(100, 13);
            this.lblDescribeChildren.TabIndex = 10;
            this.lblDescribeChildren.Text = "Number of Children:";
            // 
            // lblDescribeTotal
            // 
            this.lblDescribeTotal.AutoSize = true;
            this.lblDescribeTotal.Location = new System.Drawing.Point(682, 246);
            this.lblDescribeTotal.Name = "lblDescribeTotal";
            this.lblDescribeTotal.Size = new System.Drawing.Size(34, 13);
            this.lblDescribeTotal.TabIndex = 11;
            this.lblDescribeTotal.Text = "Total:";
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(870, 521);
            this.Controls.Add(this.lblDescribeTotal);
            this.Controls.Add(this.lblDescribeChildren);
            this.Controls.Add(this.lblDescribeAdults);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.ChkParking);
            this.Controls.Add(this.rdoTwo);
            this.Controls.Add(this.rdoSingle);
            this.Controls.Add(this.lstChildren);
            this.Controls.Add(this.lstAdult);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTickets";
            this.Text = "Ticket Prices";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstAdult;
        private System.Windows.Forms.ListBox lstChildren;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.RadioButton rdoTwo;
        private System.Windows.Forms.CheckBox ChkParking;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescribeAdults;
        private System.Windows.Forms.Label lblDescribeChildren;
        private System.Windows.Forms.Label lblDescribeTotal;
    }
}

