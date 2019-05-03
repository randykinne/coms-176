namespace FinalProject
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExitButton = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.lblSongArtist = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblMusicLength = new System.Windows.Forms.Label();
            this.lblMusicProgress = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbMusic = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstvPlaylists = new System.Windows.Forms.ListView();
            this.lblNewPlaylist = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCurrentPlaylist = new System.Windows.Forms.Label();
            this.btnAltPause = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lbxSongs = new System.Windows.Forms.ListBox();
            this.lblPlaylistInfo = new System.Windows.Forms.Label();
            this.btnEditPlaylist = new System.Windows.Forms.Button();
            this.pnlBar.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBar.Controls.Add(this.label1);
            this.pnlBar.Controls.Add(this.lblExitButton);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1094, 40);
            this.pnlBar.TabIndex = 0;
            this.pnlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseDown);
            this.pnlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            this.pnlBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "myPlay";
            // 
            // lblExitButton
            // 
            this.lblExitButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitButton.ForeColor = System.Drawing.Color.White;
            this.lblExitButton.Location = new System.Drawing.Point(1043, 0);
            this.lblExitButton.Name = "lblExitButton";
            this.lblExitButton.Size = new System.Drawing.Size(51, 40);
            this.lblExitButton.TabIndex = 0;
            this.lblExitButton.Text = "X";
            this.lblExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExitButton.Click += new System.EventHandler(this.lblExitButton_Click);
            this.lblExitButton.MouseLeave += new System.EventHandler(this.lblExitButton_MouseLeave);
            this.lblExitButton.MouseHover += new System.EventHandler(this.lblExitButton_MouseHover);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBottom.Controls.Add(this.btnPrevious);
            this.pnlBottom.Controls.Add(this.btnNext);
            this.pnlBottom.Controls.Add(this.btnPlayPause);
            this.pnlBottom.Controls.Add(this.lblSongArtist);
            this.pnlBottom.Controls.Add(this.lblSongName);
            this.pnlBottom.Controls.Add(this.lblMusicLength);
            this.pnlBottom.Controls.Add(this.lblMusicProgress);
            this.pnlBottom.Controls.Add(this.tbVolume);
            this.pnlBottom.Controls.Add(this.pictureBox1);
            this.pnlBottom.Controls.Add(this.tbMusic);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 471);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1094, 110);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPrevious.Location = new System.Drawing.Point(391, 40);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrevious.Size = new System.Drawing.Size(94, 23);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "PREVIOUS";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.Location = new System.Drawing.Point(625, 40);
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNext.Size = new System.Drawing.Size(94, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.Location = new System.Drawing.Point(517, 40);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 19;
            this.btnPlayPause.Text = "PLAY";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.AutoSize = true;
            this.lblSongArtist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongArtist.ForeColor = System.Drawing.Color.White;
            this.lblSongArtist.Location = new System.Drawing.Point(143, 40);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.Size = new System.Drawing.Size(39, 17);
            this.lblSongArtist.TabIndex = 18;
            this.lblSongArtist.Text = "Artist";
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.White;
            this.lblSongName.Location = new System.Drawing.Point(143, 19);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(101, 21);
            this.lblSongName.TabIndex = 17;
            this.lblSongName.Text = "Song Name";
            // 
            // lblMusicLength
            // 
            this.lblMusicLength.AutoSize = true;
            this.lblMusicLength.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicLength.ForeColor = System.Drawing.Color.White;
            this.lblMusicLength.Location = new System.Drawing.Point(952, 81);
            this.lblMusicLength.Name = "lblMusicLength";
            this.lblMusicLength.Size = new System.Drawing.Size(29, 16);
            this.lblMusicLength.TabIndex = 9;
            this.lblMusicLength.Text = "0:00";
            // 
            // lblMusicProgress
            // 
            this.lblMusicProgress.AutoSize = true;
            this.lblMusicProgress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicProgress.ForeColor = System.Drawing.Color.White;
            this.lblMusicProgress.Location = new System.Drawing.Point(143, 82);
            this.lblMusicProgress.Name = "lblMusicProgress";
            this.lblMusicProgress.Size = new System.Drawing.Size(29, 16);
            this.lblMusicProgress.TabIndex = 8;
            this.lblMusicProgress.Text = "0:00";
            // 
            // tbVolume
            // 
            this.tbVolume.LargeChange = 1;
            this.tbVolume.Location = new System.Drawing.Point(1027, 15);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 83);
            this.tbVolume.TabIndex = 7;
            this.tbVolume.TabStop = false;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbVolume.Value = 10;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tbMusic
            // 
            this.tbMusic.Location = new System.Drawing.Point(167, 81);
            this.tbMusic.Name = "tbMusic";
            this.tbMusic.Size = new System.Drawing.Size(788, 45);
            this.tbMusic.TabIndex = 1;
            this.tbMusic.TabStop = false;
            this.tbMusic.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbMusic.Scroll += new System.EventHandler(this.tbMusic_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstvPlaylists);
            this.panel1.Controls.Add(this.lblNewPlaylist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 431);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PLAYLISTS";
            // 
            // lstvPlaylists
            // 
            this.lstvPlaylists.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstvPlaylists.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstvPlaylists.AllowColumnReorder = true;
            this.lstvPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lstvPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstvPlaylists.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvPlaylists.ForeColor = System.Drawing.Color.Silver;
            this.lstvPlaylists.FullRowSelect = true;
            this.lstvPlaylists.GridLines = true;
            this.lstvPlaylists.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstvPlaylists.HideSelection = false;
            this.lstvPlaylists.LabelWrap = false;
            this.lstvPlaylists.Location = new System.Drawing.Point(12, 29);
            this.lstvPlaylists.MultiSelect = false;
            this.lstvPlaylists.Name = "lstvPlaylists";
            this.lstvPlaylists.Scrollable = false;
            this.lstvPlaylists.Size = new System.Drawing.Size(185, 357);
            this.lstvPlaylists.TabIndex = 1;
            this.lstvPlaylists.TabStop = false;
            this.lstvPlaylists.UseCompatibleStateImageBehavior = false;
            this.lstvPlaylists.View = System.Windows.Forms.View.SmallIcon;
            this.lstvPlaylists.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.lstvPlaylists_ItemMouseHover);
            this.lstvPlaylists.SelectedIndexChanged += new System.EventHandler(this.lstvPlaylists_SelectedIndexChanged);
            // 
            // lblNewPlaylist
            // 
            this.lblNewPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNewPlaylist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.lblNewPlaylist.Location = new System.Drawing.Point(12, 389);
            this.lblNewPlaylist.Name = "lblNewPlaylist";
            this.lblNewPlaylist.Size = new System.Drawing.Size(185, 42);
            this.lblNewPlaylist.TabIndex = 0;
            this.lblNewPlaylist.Text = "+ New Playlist";
            this.lblNewPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNewPlaylist.Click += new System.EventHandler(this.lblNewPlaylist_Click);
            this.lblNewPlaylist.MouseLeave += new System.EventHandler(this.lblNewPlaylist_MouseLeave);
            this.lblNewPlaylist.MouseHover += new System.EventHandler(this.lblNewPlaylist_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(231, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblCurrentPlaylist
            // 
            this.lblCurrentPlaylist.AutoSize = true;
            this.lblCurrentPlaylist.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlaylist.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPlaylist.Location = new System.Drawing.Point(353, 118);
            this.lblCurrentPlaylist.Name = "lblCurrentPlaylist";
            this.lblCurrentPlaylist.Size = new System.Drawing.Size(213, 32);
            this.lblCurrentPlaylist.TabIndex = 11;
            this.lblCurrentPlaylist.Text = "EMPTY PLAYLIST";
            // 
            // btnAltPause
            // 
            this.btnAltPause.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAltPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAltPause.FlatAppearance.BorderSize = 0;
            this.btnAltPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltPause.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltPause.ForeColor = System.Drawing.Color.Transparent;
            this.btnAltPause.Location = new System.Drawing.Point(231, 189);
            this.btnAltPause.Name = "btnAltPause";
            this.btnAltPause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAltPause.Size = new System.Drawing.Size(75, 23);
            this.btnAltPause.TabIndex = 12;
            this.btnAltPause.Text = "PLAY";
            this.btnAltPause.UseVisualStyleBackColor = false;
            this.btnAltPause.Click += new System.EventHandler(this.btnAltPause_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShuffle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnShuffle.Location = new System.Drawing.Point(321, 189);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShuffle.Size = new System.Drawing.Size(94, 23);
            this.btnShuffle.TabIndex = 13;
            this.btnShuffle.Text = "SHUFFLE";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(978, 403);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(94, 23);
            this.axWMP.TabIndex = 14;
            this.axWMP.Visible = false;
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSong.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSong.Location = new System.Drawing.Point(659, 189);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddSong.Size = new System.Drawing.Size(94, 23);
            this.btnAddSong.TabIndex = 15;
            this.btnAddSong.Text = "ADD SONG";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lbxSongs
            // 
            this.lbxSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbxSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxSongs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSongs.ForeColor = System.Drawing.Color.White;
            this.lbxSongs.FormattingEnabled = true;
            this.lbxSongs.ItemHeight = 21;
            this.lbxSongs.Location = new System.Drawing.Point(231, 218);
            this.lbxSongs.Name = "lbxSongs";
            this.lbxSongs.Size = new System.Drawing.Size(588, 231);
            this.lbxSongs.TabIndex = 16;
            this.lbxSongs.SelectedIndexChanged += new System.EventHandler(this.lbxSongs_SelectedIndexChanged);
            // 
            // lblPlaylistInfo
            // 
            this.lblPlaylistInfo.AutoSize = true;
            this.lblPlaylistInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistInfo.ForeColor = System.Drawing.Color.White;
            this.lblPlaylistInfo.Location = new System.Drawing.Point(356, 150);
            this.lblPlaylistInfo.Name = "lblPlaylistInfo";
            this.lblPlaylistInfo.Size = new System.Drawing.Size(105, 16);
            this.lblPlaylistInfo.TabIndex = 10;
            this.lblPlaylistInfo.Text = "12 songs, 1 hr 11 m";
            // 
            // btnEditPlaylist
            // 
            this.btnEditPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditPlaylist.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPlaylist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPlaylist.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEditPlaylist.Location = new System.Drawing.Point(559, 189);
            this.btnEditPlaylist.Name = "btnEditPlaylist";
            this.btnEditPlaylist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditPlaylist.Size = new System.Drawing.Size(94, 23);
            this.btnEditPlaylist.TabIndex = 17;
            this.btnEditPlaylist.Text = "EDIT";
            this.btnEditPlaylist.UseVisualStyleBackColor = false;
            this.btnEditPlaylist.Click += new System.EventHandler(this.btnEditPlaylist_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1094, 581);
            this.Controls.Add(this.btnEditPlaylist);
            this.Controls.Add(this.lbxSongs);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.axWMP);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnAltPause);
            this.Controls.Add(this.lblPlaylistInfo);
            this.Controls.Add(this.lblCurrentPlaylist);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myPlay - My Playful Playlist";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbMusic;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMusicLength;
        private System.Windows.Forms.Label lblMusicProgress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewPlaylist;
        private System.Windows.Forms.ListView lstvPlaylists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCurrentPlaylist;
        private System.Windows.Forms.Button btnAltPause;
        private System.Windows.Forms.Button btnShuffle;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.ListBox lbxSongs;
        private System.Windows.Forms.Label lblSongArtist;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblPlaylistInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnEditPlaylist;
    }
}

