namespace Program6
{
    partial class frmMPGRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMPGRating));
            this.nudMileageStart = new System.Windows.Forms.NumericUpDown();
            this.nudMileageEnd = new System.Windows.Forms.NumericUpDown();
            this.nudGallonsUsed = new System.Windows.Forms.NumericUpDown();
            this.tbxCurrentMPG = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxHighestMPG = new System.Windows.Forms.TextBox();
            this.tbxLowestMPG = new System.Windows.Forms.TextBox();
            this.tbxOverallMPG = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxRatings = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileageStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileageEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGallonsUsed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudMileageStart
            // 
            this.nudMileageStart.DecimalPlaces = 1;
            this.nudMileageStart.Location = new System.Drawing.Point(114, 19);
            this.nudMileageStart.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMileageStart.Name = "nudMileageStart";
            this.nudMileageStart.Size = new System.Drawing.Size(120, 20);
            this.nudMileageStart.TabIndex = 0;
            this.nudMileageStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMileageStart.ValueChanged += new System.EventHandler(this.nudMileageStart_ValueChanged);
            // 
            // nudMileageEnd
            // 
            this.nudMileageEnd.DecimalPlaces = 1;
            this.nudMileageEnd.Location = new System.Drawing.Point(114, 45);
            this.nudMileageEnd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMileageEnd.Name = "nudMileageEnd";
            this.nudMileageEnd.Size = new System.Drawing.Size(120, 20);
            this.nudMileageEnd.TabIndex = 1;
            this.nudMileageEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMileageEnd.ValueChanged += new System.EventHandler(this.nudMileageEnd_ValueChanged);
            // 
            // nudGallonsUsed
            // 
            this.nudGallonsUsed.DecimalPlaces = 2;
            this.nudGallonsUsed.Location = new System.Drawing.Point(114, 71);
            this.nudGallonsUsed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGallonsUsed.Name = "nudGallonsUsed";
            this.nudGallonsUsed.Size = new System.Drawing.Size(120, 20);
            this.nudGallonsUsed.TabIndex = 2;
            this.nudGallonsUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGallonsUsed.ValueChanged += new System.EventHandler(this.nudGallonsUsed_ValueChanged);
            // 
            // tbxCurrentMPG
            // 
            this.tbxCurrentMPG.Location = new System.Drawing.Point(114, 97);
            this.tbxCurrentMPG.Name = "tbxCurrentMPG";
            this.tbxCurrentMPG.ReadOnly = true;
            this.tbxCurrentMPG.Size = new System.Drawing.Size(120, 20);
            this.tbxCurrentMPG.TabIndex = 3;
            this.tbxCurrentMPG.Text = "0.0";
            this.tbxCurrentMPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudMileageStart);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.nudMileageEnd);
            this.groupBox1.Controls.Add(this.tbxCurrentMPG);
            this.groupBox1.Controls.Add(this.nudGallonsUsed);
            this.groupBox1.Location = new System.Drawing.Point(437, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current MPG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gallons Used:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ending Mileage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Starting Mileage:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxHighestMPG);
            this.groupBox2.Controls.Add(this.tbxLowestMPG);
            this.groupBox2.Controls.Add(this.tbxOverallMPG);
            this.groupBox2.Location = new System.Drawing.Point(437, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 125);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Overall Rating";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Highest MPG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lowest MPG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Overall MPG:";
            // 
            // tbxHighestMPG
            // 
            this.tbxHighestMPG.Location = new System.Drawing.Point(114, 85);
            this.tbxHighestMPG.Name = "tbxHighestMPG";
            this.tbxHighestMPG.ReadOnly = true;
            this.tbxHighestMPG.Size = new System.Drawing.Size(120, 20);
            this.tbxHighestMPG.TabIndex = 6;
            this.tbxHighestMPG.Text = "0.0";
            this.tbxHighestMPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxLowestMPG
            // 
            this.tbxLowestMPG.Location = new System.Drawing.Point(114, 59);
            this.tbxLowestMPG.Name = "tbxLowestMPG";
            this.tbxLowestMPG.ReadOnly = true;
            this.tbxLowestMPG.Size = new System.Drawing.Size(120, 20);
            this.tbxLowestMPG.TabIndex = 5;
            this.tbxLowestMPG.Text = "0.0";
            this.tbxLowestMPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxOverallMPG
            // 
            this.tbxOverallMPG.Location = new System.Drawing.Point(114, 33);
            this.tbxOverallMPG.Name = "tbxOverallMPG";
            this.tbxOverallMPG.ReadOnly = true;
            this.tbxOverallMPG.Size = new System.Drawing.Size(120, 20);
            this.tbxOverallMPG.TabIndex = 3;
            this.tbxOverallMPG.Text = "0.0";
            this.tbxOverallMPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(603, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MPG Ratings";
            // 
            // lbxRatings
            // 
            this.lbxRatings.FormattingEnabled = true;
            this.lbxRatings.Location = new System.Drawing.Point(25, 55);
            this.lbxRatings.Name = "lbxRatings";
            this.lbxRatings.Size = new System.Drawing.Size(388, 303);
            this.lbxRatings.TabIndex = 8;
            // 
            // frmMPGRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 437);
            this.Controls.Add(this.lbxRatings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMPGRating";
            this.Text = "MPG Rating";
            ((System.ComponentModel.ISupportInitialize)(this.nudMileageStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileageEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGallonsUsed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMileageStart;
        private System.Windows.Forms.NumericUpDown nudMileageEnd;
        private System.Windows.Forms.NumericUpDown nudGallonsUsed;
        private System.Windows.Forms.TextBox tbxCurrentMPG;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxHighestMPG;
        private System.Windows.Forms.TextBox tbxLowestMPG;
        private System.Windows.Forms.TextBox tbxOverallMPG;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxRatings;
    }
}

