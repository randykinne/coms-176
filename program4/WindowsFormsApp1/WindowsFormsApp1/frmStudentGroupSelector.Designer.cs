namespace WindowsFormsApp1
{
    partial class frmStudentGroupSelector
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
            this.listBoxHome = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDisplayGroups = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listBoxGroup1 = new System.Windows.Forms.ListBox();
            this.listBoxGroup2 = new System.Windows.Forms.ListBox();
            this.groupBoxHome = new System.Windows.Forms.GroupBox();
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxHome.SuspendLayout();
            this.groupBoxDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxHome
            // 
            this.listBoxHome.FormattingEnabled = true;
            this.listBoxHome.Location = new System.Drawing.Point(238, 31);
            this.listBoxHome.Name = "listBoxHome";
            this.listBoxHome.Size = new System.Drawing.Size(324, 277);
            this.listBoxHome.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(45, 31);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(175, 59);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read From File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDisplayGroups
            // 
            this.btnDisplayGroups.Location = new System.Drawing.Point(45, 136);
            this.btnDisplayGroups.Name = "btnDisplayGroups";
            this.btnDisplayGroups.Size = new System.Drawing.Size(175, 59);
            this.btnDisplayGroups.TabIndex = 2;
            this.btnDisplayGroups.Text = "Display Groups";
            this.btnDisplayGroups.UseVisualStyleBackColor = true;
            this.btnDisplayGroups.Click += new System.EventHandler(this.btnDisplayGroups_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(45, 249);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 59);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listBoxGroup1
            // 
            this.listBoxGroup1.FormattingEnabled = true;
            this.listBoxGroup1.Location = new System.Drawing.Point(385, 167);
            this.listBoxGroup1.Name = "listBoxGroup1";
            this.listBoxGroup1.Size = new System.Drawing.Size(324, 121);
            this.listBoxGroup1.TabIndex = 4;
            // 
            // listBoxGroup2
            // 
            this.listBoxGroup2.FormattingEnabled = true;
            this.listBoxGroup2.Location = new System.Drawing.Point(29, 167);
            this.listBoxGroup2.Name = "listBoxGroup2";
            this.listBoxGroup2.Size = new System.Drawing.Size(324, 121);
            this.listBoxGroup2.TabIndex = 5;
            // 
            // groupBoxHome
            // 
            this.groupBoxHome.Controls.Add(this.btnClose);
            this.groupBoxHome.Controls.Add(this.btnDisplayGroups);
            this.groupBoxHome.Controls.Add(this.btnRead);
            this.groupBoxHome.Controls.Add(this.listBoxHome);
            this.groupBoxHome.Location = new System.Drawing.Point(72, 12);
            this.groupBoxHome.Name = "groupBoxHome";
            this.groupBoxHome.Size = new System.Drawing.Size(590, 335);
            this.groupBoxHome.TabIndex = 6;
            this.groupBoxHome.TabStop = false;
            this.groupBoxHome.Text = "Students in Class";
            // 
            // groupBoxDisplay
            // 
            this.groupBoxDisplay.Controls.Add(this.label2);
            this.groupBoxDisplay.Controls.Add(this.label1);
            this.groupBoxDisplay.Controls.Add(this.btnReturn);
            this.groupBoxDisplay.Controls.Add(this.listBoxGroup2);
            this.groupBoxDisplay.Controls.Add(this.listBoxGroup1);
            this.groupBoxDisplay.Location = new System.Drawing.Point(72, 12);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Size = new System.Drawing.Size(808, 346);
            this.groupBoxDisplay.TabIndex = 7;
            this.groupBoxDisplay.TabStop = false;
            this.groupBoxDisplay.Text = "Groups";
            this.groupBoxDisplay.Enter += new System.EventHandler(this.groupBoxDisplay_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Group 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Group 1";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(108, 64);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(507, 38);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Group Selector";
            // 
            // frmStudentGroupSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(934, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxDisplay);
            this.Controls.Add(this.groupBoxHome);
            this.Name = "frmStudentGroupSelector";
            this.Text = "Student Group Selector";
            this.Load += new System.EventHandler(this.frmClassGroupHelper_Load);
            this.groupBoxHome.ResumeLayout(false);
            this.groupBoxDisplay.ResumeLayout(false);
            this.groupBoxDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHome;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDisplayGroups;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listBoxGroup1;
        private System.Windows.Forms.ListBox listBoxGroup2;
        private System.Windows.Forms.GroupBox groupBoxHome;
        private System.Windows.Forms.GroupBox groupBoxDisplay;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

