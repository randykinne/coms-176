namespace projectone
{
    partial class frmInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformation));
            this.btnExit = new System.Windows.Forms.Button();
            this.picHighSchool = new System.Windows.Forms.PictureBox();
            this.picMott = new System.Windows.Forms.PictureBox();
            this.picNextStep = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHighSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMott)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextStep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(597, 617);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // picHighSchool
            // 
            this.picHighSchool.Image = ((System.Drawing.Image)(resources.GetObject("picHighSchool.Image")));
            this.picHighSchool.Location = new System.Drawing.Point(79, 153);
            this.picHighSchool.Name = "picHighSchool";
            this.picHighSchool.Size = new System.Drawing.Size(119, 126);
            this.picHighSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHighSchool.TabIndex = 1;
            this.picHighSchool.TabStop = false;
            this.picHighSchool.Click += new System.EventHandler(this.pictureLF_Click);
            // 
            // picMott
            // 
            this.picMott.Image = ((System.Drawing.Image)(resources.GetObject("picMott.Image")));
            this.picMott.Location = new System.Drawing.Point(283, 153);
            this.picMott.Name = "picMott";
            this.picMott.Size = new System.Drawing.Size(119, 126);
            this.picMott.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMott.TabIndex = 2;
            this.picMott.TabStop = false;
            this.picMott.Click += new System.EventHandler(this.pictureMott_Click);
            // 
            // picNextStep
            // 
            this.picNextStep.Image = ((System.Drawing.Image)(resources.GetObject("picNextStep.Image")));
            this.picNextStep.Location = new System.Drawing.Point(483, 153);
            this.picNextStep.Name = "picNextStep";
            this.picNextStep.Size = new System.Drawing.Size(119, 126);
            this.picNextStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNextStep.TabIndex = 3;
            this.picNextStep.TabStop = false;
            this.picNextStep.Click += new System.EventHandler(this.pictureNexly_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(79, 326);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(523, 109);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Select a logo to learn more information about Randy Kinne";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picNextStep);
            this.Controls.Add(this.picMott);
            this.Controls.Add(this.picHighSchool);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInformation";
            this.Text = "College/Employment Information";
            ((System.ComponentModel.ISupportInitialize)(this.picHighSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMott)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextStep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picHighSchool;
        private System.Windows.Forms.PictureBox picMott;
        private System.Windows.Forms.PictureBox picNextStep;
        private System.Windows.Forms.Label lblDescription;
    }
}

