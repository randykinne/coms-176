namespace Program7
{
    partial class frmNatureExcursions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNatureExcursions));
            this.gbxProfile = new System.Windows.Forms.GroupBox();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoNatureTrail = new System.Windows.Forms.RadioButton();
            this.rdoKayakTour = new System.Windows.Forms.RadioButton();
            this.rdoBoatExcursion = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxCustomers = new System.Windows.Forms.ComboBox();
            this.gbxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProfile
            // 
            this.gbxProfile.Controls.Add(this.tbxComment);
            this.gbxProfile.Controls.Add(this.btnSave);
            this.gbxProfile.Controls.Add(this.btnCancel);
            this.gbxProfile.Controls.Add(this.label4);
            this.gbxProfile.Controls.Add(this.label3);
            this.gbxProfile.Controls.Add(this.rdoNatureTrail);
            this.gbxProfile.Controls.Add(this.rdoKayakTour);
            this.gbxProfile.Controls.Add(this.rdoBoatExcursion);
            this.gbxProfile.Controls.Add(this.label1);
            this.gbxProfile.Controls.Add(this.label2);
            this.gbxProfile.Controls.Add(this.tbxLastName);
            this.gbxProfile.Controls.Add(this.tbxFirstName);
            this.gbxProfile.Enabled = false;
            this.gbxProfile.Location = new System.Drawing.Point(12, 178);
            this.gbxProfile.Name = "gbxProfile";
            this.gbxProfile.Size = new System.Drawing.Size(609, 344);
            this.gbxProfile.TabIndex = 0;
            this.gbxProfile.TabStop = false;
            this.gbxProfile.Text = "Customer Profile";
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(131, 199);
            this.tbxComment.Multiline = true;
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxComment.Size = new System.Drawing.Size(460, 105);
            this.tbxComment.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Location = new System.Drawing.Point(435, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCancel.Location = new System.Drawing.Point(516, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preferences:";
            // 
            // rdoNatureTrail
            // 
            this.rdoNatureTrail.AutoSize = true;
            this.rdoNatureTrail.Location = new System.Drawing.Point(131, 127);
            this.rdoNatureTrail.Name = "rdoNatureTrail";
            this.rdoNatureTrail.Size = new System.Drawing.Size(80, 17);
            this.rdoNatureTrail.TabIndex = 6;
            this.rdoNatureTrail.Text = "Nature Trail";
            this.rdoNatureTrail.UseVisualStyleBackColor = true;
            // 
            // rdoKayakTour
            // 
            this.rdoKayakTour.AutoSize = true;
            this.rdoKayakTour.Location = new System.Drawing.Point(253, 127);
            this.rdoKayakTour.Name = "rdoKayakTour";
            this.rdoKayakTour.Size = new System.Drawing.Size(80, 17);
            this.rdoKayakTour.TabIndex = 7;
            this.rdoKayakTour.Text = "Kayak Tour";
            this.rdoKayakTour.UseVisualStyleBackColor = true;
            // 
            // rdoBoatExcursion
            // 
            this.rdoBoatExcursion.AutoSize = true;
            this.rdoBoatExcursion.Location = new System.Drawing.Point(131, 150);
            this.rdoBoatExcursion.Name = "rdoBoatExcursion";
            this.rdoBoatExcursion.Size = new System.Drawing.Size(96, 17);
            this.rdoBoatExcursion.TabIndex = 8;
            this.rdoBoatExcursion.Text = "Boat Excursion";
            this.rdoBoatExcursion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name: ";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(131, 81);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(460, 20);
            this.tbxLastName.TabIndex = 5;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(131, 55);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(460, 20);
            this.tbxFirstName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Location = new System.Drawing.Point(384, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEdit.Location = new System.Drawing.Point(465, 151);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDelete.Location = new System.Drawing.Point(546, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 152);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.FormattingEnabled = true;
            this.cbxCustomers.Location = new System.Drawing.Point(12, 151);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(347, 21);
            this.cbxCustomers.TabIndex = 0;
            this.cbxCustomers.SelectedIndexChanged += new System.EventHandler(this.cbxCustomers_SelectedIndexChanged);
            // 
            // frmNatureExcursions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 534);
            this.Controls.Add(this.cbxCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxProfile);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Name = "frmNatureExcursions";
            this.Text = "Nature Excursions!";
            this.gbxProfile.ResumeLayout(false);
            this.gbxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProfile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rdoKayakTour;
        private System.Windows.Forms.RadioButton rdoNatureTrail;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoBoatExcursion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxCustomers;
        private System.Windows.Forms.TextBox tbxComment;
    }
}

