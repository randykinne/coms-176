namespace FinalProject
{
    partial class frmNewPlaylist
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
            this.btnNewPlaylist = new System.Windows.Forms.Button();
            this.btnAddExistingPlaylist = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbNewPlaylist = new System.Windows.Forms.TextBox();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlaylist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlaylist.Location = new System.Drawing.Point(12, 61);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(148, 88);
            this.btnNewPlaylist.TabIndex = 0;
            this.btnNewPlaylist.Text = "NEW PLAYLIST";
            this.btnNewPlaylist.UseVisualStyleBackColor = false;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // btnAddExistingPlaylist
            // 
            this.btnAddExistingPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddExistingPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExistingPlaylist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExistingPlaylist.Location = new System.Drawing.Point(166, 61);
            this.btnAddExistingPlaylist.Name = "btnAddExistingPlaylist";
            this.btnAddExistingPlaylist.Size = new System.Drawing.Size(153, 88);
            this.btnAddExistingPlaylist.TabIndex = 1;
            this.btnAddExistingPlaylist.Text = "ADD EXISTING PLAYLIST";
            this.btnAddExistingPlaylist.UseVisualStyleBackColor = false;
            this.btnAddExistingPlaylist.Click += new System.EventHandler(this.btnAddExistingPlaylist_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(325, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 88);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbNewPlaylist
            // 
            this.tbNewPlaylist.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPlaylist.Location = new System.Drawing.Point(177, 96);
            this.tbNewPlaylist.Name = "tbNewPlaylist";
            this.tbNewPlaylist.Size = new System.Drawing.Size(133, 21);
            this.tbNewPlaylist.TabIndex = 3;
            this.tbNewPlaylist.Visible = false;
            this.tbNewPlaylist.TextChanged += new System.EventHandler(this.tbNewPlaylist_TextChanged);
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaylistName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.Color.White;
            this.lblPlaylistName.Location = new System.Drawing.Point(174, 76);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(98, 17);
            this.lblPlaylistName.TabIndex = 4;
            this.lblPlaylistName.Text = "Playlist Name:";
            this.lblPlaylistName.Visible = false;
            // 
            // frmNewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(485, 213);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.tbNewPlaylist);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddExistingPlaylist);
            this.Controls.Add(this.btnNewPlaylist);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewPlaylist";
            this.Text = "frmNewPlaylist";
            this.Load += new System.EventHandler(this.frmNewPlaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPlaylist;
        private System.Windows.Forms.Button btnAddExistingPlaylist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbNewPlaylist;
        private System.Windows.Forms.Label lblPlaylistName;
    }
}