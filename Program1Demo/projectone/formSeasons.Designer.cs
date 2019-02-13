namespace projectone
{
    partial class formSeasons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSeasons));
            this.pictureCold = new System.Windows.Forms.PictureBox();
            this.pictureWarm = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWarm)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCold
            // 
            this.pictureCold.Image = ((System.Drawing.Image)(resources.GetObject("pictureCold.Image")));
            this.pictureCold.Location = new System.Drawing.Point(12, 12);
            this.pictureCold.Name = "pictureCold";
            this.pictureCold.Size = new System.Drawing.Size(303, 276);
            this.pictureCold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCold.TabIndex = 0;
            this.pictureCold.TabStop = false;
            this.pictureCold.Click += new System.EventHandler(this.pictureCold_Click);
            // 
            // pictureWarm
            // 
            this.pictureWarm.Image = ((System.Drawing.Image)(resources.GetObject("pictureWarm.Image")));
            this.pictureWarm.Location = new System.Drawing.Point(332, 12);
            this.pictureWarm.Name = "pictureWarm";
            this.pictureWarm.Size = new System.Drawing.Size(195, 276);
            this.pictureWarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWarm.TabIndex = 1;
            this.pictureWarm.TabStop = false;
            this.pictureWarm.Click += new System.EventHandler(this.pictureWarm_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(452, 437);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(12, 352);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(515, 23);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "Click on the picture of your preferred climate.";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessage.Click += new System.EventHandler(this.labelMessage_Click);
            // 
            // formSeasons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 475);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureWarm);
            this.Controls.Add(this.pictureCold);
            this.Name = "formSeasons";
            this.Text = "Form Seasons";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCold;
        private System.Windows.Forms.PictureBox pictureWarm;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelMessage;
    }
}

